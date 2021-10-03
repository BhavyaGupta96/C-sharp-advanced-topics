using System;

namespace EventsExample
{
    class Program
    { 
        static void Main(string[] args)
        {
            Video v = new Video() { Title ="Video 1"};
            VideoEncoder ve = new VideoEncoder(); //publisher
            MailService ms = new MailService(); //subscriber
            MessageService mes = new MessageService(); //subscriber

            ve.VideoEncoded += ms.OnVideoEncoded;
            ve.VideoEncoded += mes.OnVideoEncoded;//RHS is pointer to method and not a function call
            ve.Encode(v);
        }
    }
     
}
