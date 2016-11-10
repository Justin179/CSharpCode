using System;

namespace ConsoleApp.EventsAndDelegates
{
    public class TextMessage
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("TextMessage: sending a text: "+args.Video.Title);
        }
    }
}