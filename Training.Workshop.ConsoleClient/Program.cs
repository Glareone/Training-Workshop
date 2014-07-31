using System;
using System.Linq;

using Training.Workshop.Data.FileSystem;
using Training.Workshop.Domain.Entities;
using Training.Workshop.Service;

namespace Training.Workshop.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup
            Domain.Context.Current.UserService = new UserService();
            Data.Context.Current.RepositoryFactory = new RepositoryFactory();

            // execute

            string command;
            while (!string.IsNullOrEmpty(command = Console.ReadLine()))
            {
                // adduser username password
                var commandArgs = command.Split(' ');
                switch (commandArgs[0])
                {
                    case "adduser":
                        User.Create(commandArgs[1], commandArgs[2]);

                        break;
                    default:
                        throw new InvalidOperationException("Unknown command.");
                }
            }
        }
    }
}
