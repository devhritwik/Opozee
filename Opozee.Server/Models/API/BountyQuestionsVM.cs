﻿using Opozee.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opozee.Server.Models.API
{
    public class BountyQuestionsVM
    {
        public int BountyId { get; set; }
        public int QuestionId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> BountyCreatedOn { get; set; }
        public string PostQuestion { get; set; }
        public string HashTags { get; set; }
        public string TaggedUser { get; set; }
        public Nullable<System.DateTime> QuestionCreatedOn { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ImageURL { get; set; }
        public string Email { get; set; }
        public string SocialID { get; set; }
        public Nullable<int> YesCount { get; set; }
        public Nullable<int> NoCount { get; set; }
        public Nullable<int> TotalLikes { get; set; }
        public Nullable<int> TotalDisLikes { get; set; }
        public Nullable<int> Score { get; set; }


        public Comments MostYesLiked { get; set; }
        public Comments MostNoLiked { get; set; }
        public List<Comments> Comments { get; set; }
    }
}