﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Chater.Models
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Password { get; set; }

        public bool HasPassword { get; set; }
        
        [BsonElement]
        public IEnumerable<Chat> Chats { get; set; }
        
    }
}