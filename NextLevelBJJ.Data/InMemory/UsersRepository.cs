using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class UsersRepository
    {
        private List<User> users = new List<User>()
        {
            new User
            {
                UserId = Guid.Parse("e4a1ff62-c375-46a4-88e9-2b8a73cd1f2c"),
                Name = "Marcelo",
                Surname = "Garcia",
                CarnetId = Guid.Parse("988a9a93-e9cc-41d6-9c86-3c3177cea5f1")                
            },
            new User
            {
                UserId = Guid.Parse("19595c1b-9269-486f-8e05-7fb60d4b6408"),
                Name = "Adam",
                Surname = "Wardziński",
                CarnetId = Guid.Parse("34418698-f406-49d7-87d2-c237ad865519")                
            },
            new User
            {
                UserId = Guid.Parse("bfb2ffa2-1e9b-409c-86f2-198199d2701b"),
                Name = "Felipe",
                Surname = "Pena",
                CarnetId = Guid.Parse("e371d29a-f14e-4c01-8b9e-b54fe6d73b8d")                
            },
            new User
            {
                UserId = Guid.Parse("36279b59-1422-4089-b3b0-d733cae9b54f"),
                Name = "Helio",
                Surname = "Gracie",
                CarnetId = Guid.Parse("2c65a289-28e7-4e3f-b074-5d8089f2a349")                
            }        
        };
    }
}