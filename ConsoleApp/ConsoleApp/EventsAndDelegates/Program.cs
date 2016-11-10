using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EventsAndDelegates
{
    class Program
    {

        public static void Main(string[] args)
        {
            var video = new Video() {Title = "video one"};
            var videoEncoder = new VideoEncoder(); // publisher

            
            var mailService = new MailService(); // subscriber
            var textMessage = new TextMessage(); // subscriber
            // 註冊: 把subscriber的方法指向publisher的主物件(注意是+=)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textMessage.OnVideoEncoded;


            videoEncoder.Encode(video);
        }
    }
}
