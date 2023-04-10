using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Dialog
{
    public class UnitDialog
    {
        public List<UnitDialog> nextDialogs { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        [JsonIgnore]
        public bool End => nextDialogs.Count == 0;
        public UnitDialog()
        {
            nextDialogs = new List<UnitDialog>();
            Author = "";
            Content = "";
        }
        public UnitDialog(string author, string content)
        {
            nextDialogs = new List<UnitDialog>();
            Author = author;
            Content = content;
        }
        public UnitDialog(List<UnitDialog> nextDialogs, string author, string content)
        {
            this.nextDialogs = nextDialogs;
            Author = author;
            Content = content;
        }
        private void PrintDialog() => Console.WriteLine($"{Author}: {Content}");

        public void Show()
        {
            if (nextDialogs.Count == 1)
            {
                PrintDialog();
                Console.ReadLine();
                nextDialogs[0].Show();
            }
            else if (nextDialogs.Count > 1)
            {
                int i = 1;

                foreach (UnitDialog dialog in nextDialogs)
                {
                    Console.WriteLine($"{i}: {Content}");
                    i++;
                }

                while (true)
                {
                    Console.WriteLine($"Выбирайте от 1 до {i - 1}:");
                    int number = ReadConsole();
                    Console.WriteLine();

                    if (number < 1 || number > i - 1) continue;
                    nextDialogs[number - 1].Show();

                    break;
                }
            }
            else PrintDialog();
        }
        public int ReadConsole()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return -2;
            }
        }
    }
}
