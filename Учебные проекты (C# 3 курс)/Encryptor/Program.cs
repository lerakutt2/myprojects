using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encryptor
{
    internal class Program
    {
        delegate void Message(string message);
        static Message Print = (string message) => Console.WriteLine(message);
        static void Main(string[] args)
        {
            string text = "В приемах своих господин имел что-то солидное " +
                "и высмаркивался чрезвычайно громко. Неизвестно, как он это делал, " +
                "но только нос его звучал, как труба. Это, по-видимому, совершенно " +
                "невинное достоинство приобрело, однако ж, ему много уважения со " +
                "стороны трактирного слуги, так что он всякий раз, когда слышал " +
                "этот звук, встряхивал волосами, спрашивал: не нужно ли чего? ";
            string keyPhrase = "Так думал молодой повеса, Летя в пыли на почтовых";

            Print("Вариант 8. Ключевая фраза: " + keyPhrase);
            Print("Исходный текст: " + text);

            string alphabet = MakeAlphabet(keyPhrase);
            Print("Новый алфавит: " + alphabet);
            string encText = Encrypt(text, alphabet);
            Print("Зашифрованный текст: " + encText);
            Print("Расшифрованный текст: " + Decrypt(encText, alphabet));
        }

        /// <summary>
        /// Предобрабатывает текст: приводит весь текст к верхнему регистру,
        /// удаляет все символы, не являющиеся русскими буквами
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Preproccess(string text)
        {
            text = text.ToUpper();
            StringBuilder newText = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'А' && text[i] <= 'Я')
                {
                    newText.Append(text[i]);
                }
            }

            return newText.ToString();
        }

        /// <summary>
        /// Составляет новый алфавит на основе ключавой фразы путем 
        /// предобработки фразы, сохранения
        /// во фразе только первых вхождений символов и добавления 
        /// в ее конец невошедших символов в алфавитном порядке
        /// </summary>
        /// <param name="phrase">Ключевая фраза</param>
        /// <returns>Алфавит в верхнем регистре</returns>
        static string MakeAlphabet(string phrase)
        {
            phrase = Preproccess(phrase);
            StringBuilder alphabet = new StringBuilder();
            StringBuilder russianAlphabet = new StringBuilder("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.IndexOf(phrase[i]) == i)
                {
                    alphabet.Append(phrase[i]);
                    russianAlphabet.Replace(phrase[i].ToString(), "");
                }
            }
            alphabet.Append(russianAlphabet);

            return alphabet.ToString();
        }

       /// <summary>
       /// Зашифровывает текст путем моноалфавитной замены, 
       /// затем разбивает зашифрованный текст на группы по 5 символов
       /// </summary>
       /// <param name="text">текст</param>
       /// <param name="alphabet">алфавит замены</param>
       /// <returns></returns>
        static string Encrypt(string text, string alphabet)
        {
            text = Preproccess(text);
            StringBuilder encText = new StringBuilder();
            int first = 'А';

            for (int i = 0; i < text.Length; i++)
            {
                encText.Append(alphabet[text[i] - first]);
            }

            for (int i = 5; i < encText.Length; i += 6)
            {
                encText.Insert(i, ' ');
            }
            return encText.ToString();
        }

        /// <summary>
        /// Дешифрует текст, зашифрованный с помощью моноалфавитной замены
        /// </summary>
        /// <param name="text"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        static string Decrypt(string text, string alphabet)
        {
            StringBuilder decrText = new StringBuilder();
            int first = 'А';
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(' ')) { decrText.Append(' '); }
                else
                {
                    decrText.Append((char) (alphabet.IndexOf(text[i]) + first));
                }
            }

            return decrText.ToString();
        }

    }
}
