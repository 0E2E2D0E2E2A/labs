using System.IO;
using System.Text.RegularExpressions;

namespace Lab_OOP_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string html = "";
            try
            {
                // Создаем объект WebClient для получения HTML-документа
                System.Net.WebClient client = new System.Net.WebClient();
                // Загружаем HTML-документ из URL-адреса
                html = client.DownloadString("file.html");
                // Сохраняем HTML-документ в файл
                File.WriteAllText("output.html", html);

            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string[] dictionary = { "помню", "мгновение" };
            Regex regex = new Regex(@"\b(" + string.Join("|", dictionary.Select(Regex.Escape)) + @")\b");

            string result = regex.Replace(html, match => new string('*', match.Length));

            Console.WriteLine(result);
        
        }
    }
}