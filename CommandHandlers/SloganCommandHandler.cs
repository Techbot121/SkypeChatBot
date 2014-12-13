﻿using ChatBot.Commands;
using Eka.Web.SloganGenerator;

namespace ChatBot.CommandHandlers
{
    public class SloganCommandHandler : ICommandHandler
    {
        public string Command
        {
            get { return "slogan"; }
        }

        public void Handle(MessageSink messageSink, Command command)
        {
            Slogan slogan = new Slogan(command.FullArguments);
            if (slogan.Success)
                messageSink(slogan.SloganText);
        }
    }
}