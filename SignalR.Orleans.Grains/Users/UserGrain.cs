//using System;
//using System.Collections.Generic;
//using System.Text;
//using SignalR.Orleans.Grains.Core;

//namespace SignalR.Orleans.Grains.Users
//{
//    [StorageProvider(ProviderName = Constants.STORAGE_PROVIDER)]
//    internal class UserGrain : ConnectionGrain<UserState>, IUserGrain
//    {
//        public UserGrain(ILogger<UserGrain> logger) : base(logger)
//        {
//        }
//    }

//    internal class UserState : ConnectionState
//    {
//    }
//}
