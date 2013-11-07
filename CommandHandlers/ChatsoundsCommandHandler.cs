using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ChatBot.CommandHandlers
{
    public class ChatsoundsCommandHandler : ICommandHandler
    {
       public static String GetLink(string expression)
       {
           String link = "http://threekelv.in/keylimepie/chatsounds/?s=";
           link = link + System.Web.HttpUtility.UrlPathEncode(expression);
           return link;
       }

        public string Command
        {
            get { return "cs"; }
        }

        public void Handle(MessageSink messageSink, Command command)
        {
            messageSink("[CS] " + GetLink(command.FullArguments));
        }
    }
}