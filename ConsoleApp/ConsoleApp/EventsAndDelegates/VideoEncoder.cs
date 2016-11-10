using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp.EventsAndDelegates
{
    // publisher, 一但完成了，這裡的code就不用動了，要加code，可以寫在新的subscriber，物件間彼此獨立
    class VideoEncoder
    {
        // 1 define a delegate
        // 2 define an event based on that delegate
        // 3 raise the event

        //// 定義signature
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //// 主物件
        //public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // 向訂閱者發佈訊息(call subscriber's method)
        }

        // 上面兩行，二合一 (使用EventHandler類別)(VideoEventArgs為自訂類別，用來包另一物件)
        public event EventHandler<VideoEventArgs> VideoEncoded; // 主物件

        // method:通知訂閱者
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) // 如果有訂閱者
                VideoEncoded(this, new VideoEventArgs(){Video=video});
        }

        // subscriber's method
        //public void OnVideoEncoded(object source, VideoEventArgs args)
        //{
        //    Console.WriteLine("TextMessage: sending a text" + args.Video.Title);
        //}
    }
}
