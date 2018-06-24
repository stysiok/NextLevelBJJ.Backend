using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class UsersCompetitionsRepository
    {
        private List<UsersCompetitions> usersCompetitions = new List<UsersCompetitions>()
        {
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("648aa7d3-caf5-4428-8dac-131b1ff4c415"),
                UserId = Guid.Parse("e4a1ff62-c375-46a4-88e9-2b8a73cd1f2c"),
                SigningDate = DateTime.Now.AddDays(-3)
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("648aa7d3-caf5-4428-8dac-131b1ff4c415"),
                UserId = Guid.Parse("19595c1b-9269-486f-8e05-7fb60d4b6408"),
                SigningDate = DateTime.Now.AddDays(-2)
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("95274656-71e6-47a4-9c6c-a0f71ff807bf"),
                UserId = Guid.Parse("e4a1ff62-c375-46a4-88e9-2b8a73cd1f2c"),
                SigningDate = DateTime.Now.AddDays(-6)
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("895bd674-bc1a-4085-ba78-27a71a35f178"),
                UserId = Guid.Parse("19595c1b-9269-486f-8e05-7fb60d4b6408"),
                SigningDate = DateTime.Now.AddDays(-12)
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("895bd674-bc1a-4085-ba78-27a71a35f178"),
                UserId = Guid.Parse("bfb2ffa2-1e9b-409c-86f2-198199d2701b"),
                SigningDate = DateTime.Now
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("e32dc5c9-6a4b-40f5-bdc1-cb72474bb812"),
                UserId = Guid.Parse("bfb2ffa2-1e9b-409c-86f2-198199d2701b"),
                SigningDate = DateTime.Now.AddDays(-2)
            },
            new UsersCompetitions()
            {
                CompetitionId = Guid.Parse("e32dc5c9-6a4b-40f5-bdc1-cb72474bb812"),
                UserId = Guid.Parse("36279b59-1422-4089-b3b0-d733cae9b54f"),
                SigningDate = DateTime.Now.AddDays(-4)
            },
        };

    }
}