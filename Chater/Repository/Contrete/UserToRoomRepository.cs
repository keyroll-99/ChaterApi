﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Chater.Models;
using Chater.Repository.Abstract;
using MongoDB.Driver;

namespace Chater.Repository.Contrete
{
    public class UserToRoomRepository : BaseRepository,IUserToRoomRepository
    {
        private readonly IMongoCollection<UserToRoom> _collection;
        private readonly FilterDefinitionBuilder<UserToRoom> _filterDefinitionBuilder = Builders<UserToRoom>.Filter;

        public UserToRoomRepository(IMongoClient mongoClient) : base(mongoClient)
        {
            _collection = Database.GetCollection<UserToRoom>(nameof(UserToRoom));
        }
        
        public async Task<ICollection<UserToRoom>> GetUserRoomAsync(User user)
        {
            var filter = _filterDefinitionBuilder.Eq(utr => utr.User.Id, user.Id);
            return await _collection.Find(filter).ToListAsync();

        }

        public Task DeleteUserFromRoomAsync(User user, Room room)
        {
            throw new System.NotImplementedException();
        }

    }
}