using System;
using System.Collections.Generic;
using System.Linq;

namespace Avatar
{
    public class Engine
    {
        private bool isRunning;
        private NationsBuilder nationsBuilder;

        public Engine()
        {
            this.isRunning = true;
            this.nationsBuilder = new NationsBuilder();
        }
        public void Run()
        {
            while (isRunning)
            {
                string inputCommand = this.ReadInput();
                List<string> commandParam = this.ParseInput(inputCommand);
                this.DistribudeCommand(commandParam);
            }
        }

        private void DistribudeCommand(List<string> commandParam)
        {
            string command = commandParam[0];
            commandParam.Remove(command);

            switch (command)
            {
                case "Bender":
                    this.nationsBuilder.AssignBender(commandParam);
                    break;
                case "Monuments":
                    this.nationsBuilder.AssignMonuments(commandParam);
                    break;
                case "Status":
                   string status =  this.nationsBuilder.GetStatus(commandParam[0]);
                    this.OutputWriter(status);
                    break;
                case "War":
                    this.nationsBuilder.IssueWar(commandParam[0]);
                    break;
                case "Quit":
                    string record = this.nationsBuilder.GetWarsRecord();
                    this.OutputWriter(record);
                    this.isRunning = false;
                    break;
            }
        }

        private void OutputWriter(string status)
        {
            throw new NotImplementedException();
        }

        private List<string> ParseInput(string inputCommand)
        {
            return inputCommand.Split(' ').ToList();
        }

        private string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}