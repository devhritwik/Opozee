//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opozee.Models.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int Id { get; set; }
        public Nullable<int> CommentedUserId { get; set; }
        public Nullable<int> CommentId { get; set; }
        public Nullable<int> questId { get; set; }
        public Nullable<bool> Like { get; set; }
        public Nullable<bool> Dislike { get; set; }
        public Nullable<bool> Comment { get; set; }
        public Nullable<bool> SendNotification { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
