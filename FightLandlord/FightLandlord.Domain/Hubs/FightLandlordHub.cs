using FightLandlord.Domain.Commands;
using Microsoft.AspNet.SignalR;
using System;
using System.Reflection;

namespace FightLandlord.Domain
{
    public class FightLandlordHub : Hub<IClient>
    {
        public static readonly string _assemblyName = "FightLandlord.Domain";
        public void Send(string commandName, string data)
        {
            try
            {
                Command cmd = (Command)Assembly.Load(_assemblyName).CreateInstance($"{_assemblyName}.Commands.{commandName}Command");
                cmd.Initial(this, data);
                cmd.Execute();
            }
            catch (Exception ex)
            {
                Clients.Caller.ShowMsg(ex.GetType().Name + ":" + ex.Message);
            }
        }
    }
}
