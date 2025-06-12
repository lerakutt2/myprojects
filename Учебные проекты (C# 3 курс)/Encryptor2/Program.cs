using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Encryptor
{
    internal class Program
    {
        delegate void Message(object? message);
        static Message Print = Console.WriteLine;
        static string allowedSymbols = "123";
        static void Main()
        {
            string text = "В приемах своих господин имел что-то солидное " +
                "и высмаркивался чрезвычайно громко. Неизвестно, как он это делал, " +
                "но только нос его звучал, как труба. Это, по-видимому, совершенно " +
                "невинное достоинство приобрело, однако ж, ему много уважения со " +
                "стороны трактирного слуги, так что он всякий раз, когда слышал " +
                "этот звук, встряхивал волосами, спрашивал: не нужно ли чего? ";
            string keyPhrase = "Так думал молодой повеса, Летя в пыли на почтовых";

            Print("Исходный текст: " + text);

            string[] square = MakeSquare(keyPhrase);

            Print("Квадрат:");
            foreach (var row in square) 
            {
                Print(row);
            }

            string encText = Encrypt(text, square);
            Print("Зашифрованный текст: " + encText);
            Print("Расшифрованный текст: " + Decrypt(encText, square));
        }

        /// <summary>
        /// Предобрабатывает текст: приводит весь текст к верхнему регистру,
        /// удаляет все символы, не являющиеся русскими буквами или символами, которыми
        /// заполняются пропуски в таблице (допустимые символы)
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="allowedSymbols">Допустимые символы</param>
        /// <returns></returns>
        static string Preproccess(string text)
        {
            text = text.ToUpper();
            StringBuilder newText = new(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'А' && text[i] <= 'Я' || text[i] == 'Ё')
                {
                    newText.Append(text[i]);
                }
                else if (allowedSymbols.Contains(text[i]))
                {
                    newText.Append(text[i]);
                }
            }
            return newText.ToString();
        }

        /// <summary>
        /// Составляет новый алфавит на основе ключевой фразы путем 
        /// предобработки фразы, сохранения во фразе только первых вхождений 
        /// символов и добавления в ее конец невошедших символов в алфавитном порядке.
        /// Затем из полученного набора формирует полибианский квадрат.
        /// </summary>
        /// <param name="phrase">Ключевая фраза</param>
        /// <returns>Полибианский квадрат (двумерный массив 6х6)</returns>
        static string[] MakeSquare(string phrase)
        {
            // предобработка фразы
            phrase = Preproccess(phrase);
            
            StringBuilder alphabet = new();
            StringBuilder russianAlphabet = new("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            // создаем новый алфавит
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.IndexOf(phrase[i]) == i)
                {
                    alphabet.Append(phrase[i]);
                    russianAlphabet.Replace(phrase[i].ToString(), "");
                }
            }
            alphabet.Append(russianAlphabet);
            string strAlphabet = alphabet.ToString();

            // делаем таблицу (квадрат)
            string[] square = new string[6];
            for (int i = 0; i < 5; i++)
            {
                square[i] = new string(strAlphabet.Substring(i * 6, 6));
            }
            // добавляем оставшиеся символы алфавита и заполняем пропуски 
            square[5] = strAlphabet.Substring(5 * 6, strAlphabet.Length - 5 * 6) + allowedSymbols;

            return square;
        }

        /// <summary>
        /// Разбивает текст на блоки по несколько символов
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="len">длина блока</param>
        /// <returns></returns>
        static string Split(string text, int len)
        {
            for (int i = len; i < text.Length; i += len + 1)
            {
                text = text.Insert(i, " ");
            }
            return text;
        }

        /// <summary>
        /// Зашифровывает текст методом дробления
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="square">Полибианский квадрат</param>
        /// <returns></returns>
        static string Encrypt(string text, string[] square)
        {
            text = Preproccess(text);
            StringBuilder encText = new();

            int[] rowCoord = new int[text.Length];
            int[] colCoord = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < square.Length; j++)
                { // поиск координат символа
                    int col = square[j].IndexOf(text[i]);
                    if (col != -1)
                    { // если нашли ряд, то записываем координаты
                        rowCoord[i] = j;
                        colCoord[i] = col;
                        break;
                    }
                }
            }

            // создаем шифр, состоящий из сцепленных массивов координат рядов и столбцов
            List<int> code = [.. rowCoord, .. colCoord];

            for (int i = 0; i < code.Count; i += 2)
            { // зашифровываем текст
                encText.Append(square[code[i]][code[i + 1]]);
            }

            return Split(encText.ToString(), 5);
        }

        /// <summary>
        /// Дешифрует текст, зашифрованный методом дробления
        /// </summary>
        /// <param name="encText"></param>
        /// <param name="square"></param>
        /// <returns></returns>
        static string Decrypt(string encText, string[] square)
        {
            encText = Preproccess(encText);
            StringBuilder decrText = new();
            int[] code = new int[encText.Length * 2];
            int codeIndex = 0;

            for (int i = 0; i < encText.Length; i++)
            {
                for (int j = 0; j < square.Length; j++)
                { // поиск координат символа
                    int col = square[j].IndexOf(encText[i]);
                    if (col != -1)
                    { // записываем координаты в ряд
                        code[codeIndex++] = j;
                        code[codeIndex++] = col;
                        break;
                    }
                }
            }

            for (int i = 0; i < encText.Length; i++)
            {
                decrText.Append(square[code[i]][code[i + encText.Length]]);
            }

            return Split(decrText.ToString(), 5);
        }
    }
}
