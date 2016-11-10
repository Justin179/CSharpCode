using System;

namespace ConsoleApp.EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: sending an email: "+args.Video.Title);       
        }
    }
}