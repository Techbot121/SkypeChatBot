﻿using ChatBot.Commands;
using System;
using System.Linq;

namespace ChatBot.CommandHandlers
{
    public class BofhCommandHandler : ICommandHandler
    {
        private Random rnd = new Random();
        private string[] Excuses = Properties.Resources.bofh_excuses.Split('\n');

        public string Command
        {
            get { return "bofh"; }
        }

        public string GetRandomExcuse()
        {
            int r = rnd.Next(Excuses.Count());
            return Excuses[r];
        }

        public void Handle(MessageSink messageSink, Command command)
        {
            messageSink(GetRandomExcuse());
        }
    }
}