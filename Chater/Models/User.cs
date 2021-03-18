﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Chater.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.String)]
        public Guid UserId { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string Token { get; set; }
         
    }
}