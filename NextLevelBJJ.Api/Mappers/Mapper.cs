using NextLevelBJJ.Api.InputModels;
using NextLevelBJJ.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.Mappers
{
    public class Mapper
    {
        public User Map(Core.Models.User user)
        {
            return new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Surname = user.Surname,
                CarnetId = user.CarnetId
            };
        }

        public Post Map(Core.Models.Post post)
        {
            return new Post
            {
                PostId = post.PostId,
                Author = post.Author,
                Title = post.Title,
                Text = post.Text,
                CreationDate = post.CreationDate,
                Image = post.Image
            };
        }

        public List<Post> Map(List<Core.Models.Post> posts)
        {
            return posts.Select(post =>
            {
                return Map(post);
            }).ToList();
        }

        public Carnet Map(Core.Models.Carnet carnet, Core.Models.CarnetType carnetType)
        {
            return new Carnet
            {
                CarnetId = carnet.CarnetId,
                Name = carnetType.CarnetName,
                LeftEntrences = carnet.LeftEntrences,
                EntrenceAmount = carnetType.EntrenceAmount,
                ExpirationDate = carnet.ExpirationDate,
                LastTraining = carnet.LastTraining,

            };
        }

        public List<Competition> Map(List<Core.Models.Competition> competitions, List<Core.Models.UserCompetitions> userCompetitions)
        {
            return competitions.Select(c =>
            {
                return new Competition
                {
                    CompetitionId = c.CompetitionId,
                    CompetitionType = c.CompetitionType,
                    DateAndTime = c.DateAndTime,
                    Name = c.Name,
                    Town = c.Town,
                    SingingInDate = userCompetitions.FirstOrDefault(f => f.CompetitionId == c.CompetitionId).SigningDate
                };
            }).ToList();
        }

        public List<Competition> Map(List<Core.Models.Competition> competitions)
        {
            return competitions.Select(c =>
            {
                return new Competition
                {
                    CompetitionId = c.CompetitionId,
                    CompetitionType = c.CompetitionType,
                    DateAndTime = c.DateAndTime,
                    Name = c.Name,
                    Town = c.Town
                };
            }).ToList();
        }

        public Competition Map(Core.Models.Competition competition)
        {
            return new Competition
            {
                CompetitionId = competition.CompetitionId,
                CompetitionType = competition.CompetitionType,
                DateAndTime = competition.DateAndTime,
                Name = competition.Name,
                Town = competition.Town
            };
        }

        public Core.Models.Competition Map(CompetitionInput competition)
        {
            return new Core.Models.Competition
            {
                CompetitionType = competition.CompetitionType,
                Name = competition.Name,
                Town = competition.Town,
                DateAndTime = competition.Date.Date + competition.Time.TimeOfDay
            };
        }
    }
}
