using System.Data;
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
            string text = "ufoqdfj[fcc&lj—jzqzdхyfjи*rfcqufsqиcc&l,jyхdи[qpхzkql," +
                "ja*fwиw&l,jqctи*yfsqиcc&l,ja*иr*fyyc&ljqjdхlcqpхzkqljyх*иa*q2dqq," +
                "jyхdи[иwjqjz*х[zdw,jcfa*fweхcc&ljcfjиr*fcqpхcqхjqeqjqzkegpхcqхjc" +
                "хzfcksqиcq*иwfccиrиj[иzdvafjkj[fcc&y,jqljqzaиe#uиwfcq2jqeqjquyхc" +
                "хcq2jcfjeghиqjzdf[qqja*иsхzzfjzhи*f,jиh*fhиdkq,jl*fcхcq2,jaх*х[f" +
                "pqjqjvcqpdиiхcq2.jaи[jkfcfeиyjvdхpkqjqctи*yfsqqjhv[хyjaиcqyfd#jz" +
                "aиzиh,jaиuwиe2goqqjcf*vmqdхegjaиevpqd#jcхzfcksqиcq*иwfcc&qj[иzdv" +
                "ajkjиh*fhfd&wfхyиqjqeqjl*fc2oхqz2jwjzqzdхyхjqctи*yfsqq.jwja*иsхz" +
                "zхjzwихqj[х2dхe#cиzdqjrиzv[f*zdwиj(wjsхeиyjqeqjиd[хe#c&хjхrиjи*r" +
                "fc&jqjи*rfcqufsqq),jиhoхzdwхcc&хjqeqjkиyyх*pхzkqхjи*rfcqufsqqj(и" +
                "hnх[qcхcq2)jqja*х[a*q2dq2j(g*q[qpхzkqхjeqsf),jиd[хe#c&хjr*fi[fcх" +
                "j(tquqpхzkqхjeqsf)jyиrvdjcflи[qd#z2j[*vrjzj[*vrиyjwj*fucиrиj*и[f" +
                "jиdcиmхcq2l,jwjdиyjpqzeхjkfzfgoqlz2jwиa*иzиwjaиevpхcq2,jl*fcхcq2" +
                ",jиh*fhиdkq,j*fza*иzd*fcхcq2jqjqzaиe#uиwfcq2jиa*х[хeхccиqjqctи*y" +
                "fsqq.jdfkqхjиdcиmхcq2jyхi[vjzvhnхkdfyqjhv[хyjcfu&wfd#jqctи*yfsqиc" +
                "c&yqjиdcиmхcq2yq,jfjzfyqljvpfzdwvgoqljwjcqljzvhnхkdиwj—zvhnхkdfyq" +
                "jqctи*yfsqиcc&ljиdcиmхcqq";

            Console.WriteLine("Зашифрованный текст: " + text);

            var alphabet = ValueCounts(text);
            Console.WriteLine("Частота символов текста:");
            foreach (var item in alphabet)
            {
                Console.WriteLine(item);
            }

            // Алфавит замены, подобранный на основе таблицы частотности символов
            string sortedAlphabet = " ИОНЕАРСТМДВЛПЯХКУ,ЫЦБГЧЗЬФЮЩШ()ЪЖ.-";

            Console.WriteLine("Алфавит замены: " + sortedAlphabet);
            Console.WriteLine("Расшифрованный текст: " + Decrypt(text, sortedAlphabet));
        }

        static Dictionary<char, int> ValueCounts(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (charCount.TryGetValue(c, out int value))
                { // если символ есть в словаре, увеличиваем счетчик
                    charCount[c] = value + 1;
                }
                else
                { // добавляем символ в таблицу
                    charCount.Add(c, 1); 
                }
            }

            // сортируем словарь по частоте встречающихся символов
            var sorted = from entry in charCount orderby entry.Value descending select entry;
            return sorted.ToDictionary();
        }

        static string Decrypt(string text, string sortedAlphabet)
        {
            StringBuilder decrText = new();
            // получаем частотный алфавит 
            var sortedDecrAlphabet = ValueCounts(text).Keys.ToArray();
            for (int i = 0; i < text.Length; i++)
            { 
                // получаем номер символа в алфавите частот
                int index = Array.IndexOf(sortedDecrAlphabet, text[i]);
                if (index < sortedAlphabet.Length)
                { 
                    decrText.Append(sortedAlphabet[index]);
                }
                else
                {
                    decrText.Append(text[i]);
                }
            }
            return decrText.ToString();
        }
    }
}