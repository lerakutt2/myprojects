using System;
using System.Text;

namespace Encryptor1
{
    internal class Program
    {
        static void Main()
        {
            string text = "В приемах своих господин имел что-то солидное " +
                "и высмаркивался чрезвычайно громко. Неизвестно, как он это делал, " +
                "но только нос его звучал, как труба. Это, по-видимому, совершенно " +
                "невинное достоинство приобрело, однако ж, ему много уважения со " +
                "стороны трактирного слуги, так что он всякий раз, когда слышал " +
                "этот звук, встряхивал волосами, спрашивал: не нужно ли чего? ";
            string keyPhrase = "валерия";
            string encText = Encrypt(text, keyPhrase);
            Console.WriteLine("Ключевая фраза: " + keyPhrase);
            Console.WriteLine("Исходный текст: " + text);
            Console.WriteLine("Зашифрованный текст: " + encText);
            Console.WriteLine("Расшифрованный текст: " + Decrypt(encText, keyPhrase));
        }

        /// <summary>
        /// Предобрабатывает текст: приводит весь текст к верхнему регистру,
        /// удаляет все символы, не являющиеся русскими буквами
        /// </summary>
        /// <param name="text">текст</param>
        /// <returns></returns>
        static string Preproccess(string text)
        {
            text = text.ToUpper();
            StringBuilder newText = new(text.Length);

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
        /// Возвращает в каком порядке должы идти блоки согласно ключевой фразе.
        /// </summary>
        /// <param name="phrase">Ключевая фраза</param>
        /// <returns></returns>
        static int[] MakeOrder(string phrase)
        {
            int index = 0;
            // преобразует фразу в аски-код
            List<int> asciiPhrase = [.. phrase];
            int[] code = new int[phrase.Length];
            int maxVal = 10000;
            int minVal;
            while (true)
            {
                int indexmin = asciiPhrase.IndexOf(asciiPhrase.Min());
                minVal = asciiPhrase[indexmin]; // самая младшая по алфавиту буква 
                if (minVal == maxVal) { break; }
                code[indexmin] = index;
                asciiPhrase[indexmin] = maxVal; // запоминаем какие буквы уже прошли
                index++;
            }

            return code;
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
        /// Зашифровывает текст методом перестановки, 
        /// затем разбивает зашифрованный текст на группы по 5 символов
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="alphabet">алфавит замены</param>
        /// <returns></returns>
        static string Encrypt(string text, string key)
        {
            text = Preproccess(text);
            key = Preproccess(key);

            int[] order = MakeOrder(key);
            int blocksCount = key.Length;
            StringBuilder[] blocks = new StringBuilder[blocksCount];

            // разбиваем текст на блоки
            for (int i = 0; i < blocksCount; i++)
            {
                blocks[i] = new();
                for (int j = i; j < text.Length; j += blocksCount)
                {
                    blocks[i].Append(text[j]);
                }
            }
            
            string[] stringBlocks = new string[blocksCount];
            // переставляем блоки в нужном порядке
            for (int i = 0; i < blocksCount; i++)
            {
                stringBlocks[i] = blocks[order[i]].ToString();
            }

            string encText = string.Concat(stringBlocks);

            return Split(encText, blocksCount);
        }

        /// <summary>
        /// Дешифрует текст, зашифрованный методом перестановки
        /// </summary>
        /// <param name="text"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        static string Decrypt(string encText, string key)
        {
            int[] order = MakeOrder(key);
            encText = encText.Replace(" ", null);

            int blocksCount = key.Length;
            // минимальная длина блока
            int blockLen = encText.Length / blocksCount;
            // остаток, так как не во всех блоках одинаковое количество символов
            int ost = encText.Length % blocksCount;
            string[] blocks = new string[blocksCount];
            int len; 
            int startInd = 0; 

            for (int i = 0; i < blocksCount; i += 1)
            {
                // длина конкретного блока
                len = blockLen + (order[i] < ost ? 1 : 0);
                // считываем блок
                blocks[i] = encText.Substring(startInd, len);
                startInd += len;
            }

            string[] orderedBlocks = new string[blocksCount];

            // переставляет блоки в изначальном порядке
            for (int i = 0; i < blocksCount; i++)
            {
                orderedBlocks[i] = blocks[order.ToList().IndexOf(i)];
            }
            
            StringBuilder decrText = new();
            // читает текст из блоков
            for (int i = 0; i < blockLen; i++)
            {
                for (int j = 0; j < blocksCount; j++)
                {
                    decrText.Append(orderedBlocks[j][i]);
                }
            }

            // читает остаток текста 
            for (int i = 0; i < ost; i++)
            {
                decrText.Append(orderedBlocks[i][blockLen]);
            }

            return Split(decrText.ToString(), blocksCount);
        }
    }
}
