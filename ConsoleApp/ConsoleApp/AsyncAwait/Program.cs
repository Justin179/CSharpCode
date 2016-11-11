using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Program
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    DownloadHtmlAsync("http://msdn.microsoft.com");
        //}

        static async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            // 立刻歸還控制權，程式直接往下
            string html = await webClient.DownloadStringTaskAsync(url);

            using (var sw = new StreamWriter(@"c:\projects\result.html"))
            {
                // 立刻歸還控制權，程式直接往下
                await sw.WriteAsync(html);
            }

            Console.WriteLine("execution finished");
        }


        static void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            string html = webClient.DownloadString(url);

            using (var sw = new StreamWriter(@"c:\projects\result.html"))
            {
                sw.Write(html);
            }

            Console.WriteLine("execution finished");
        }
    }


}
