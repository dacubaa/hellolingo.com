﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Considerate.Hellolingo.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HellolingoEntities : DbContext
    {
        public HellolingoEntities()
            : base("name=HellolingoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MessageVisibilityType> MessageVisibilityTypes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<LogEvent> LogEvents { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<UsersStatus> UsersStatuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ListedUser> ListedUsers { get; set; }
        public virtual DbSet<PublicUser> PublicUsers { get; set; }
        public virtual DbSet<MailRegulationStatus> MailRegulationStatuses { get; set; }
        public virtual DbSet<Mail> Mails { get; set; }
        public virtual DbSet<MailStatus> MailStatuses { get; set; }
        public virtual DbSet<UsersChanges> UsersChanges { get; set; }
        public virtual DbSet<TextChat> TextChats { get; set; }
        public virtual DbSet<SourceFeature> SourceFeatures { get; set; }
        public virtual DbSet<VoiceCallOutcome> VoiceCallOutcomes { get; set; }
        public virtual DbSet<VoiceCall> VoiceCalls { get; set; }
        public virtual DbSet<VoicePlatform> VoicePlatforms { get; set; }
        public virtual DbSet<TilesFiltering> TilesFilterings { get; set; }
        public virtual DbSet<TilesFilter> TilesFilters { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<UsersDevice> UsersDevices { get; set; }
        public virtual DbSet<NotifyStatus> NotifyStatuses { get; set; }
        public virtual DbSet<UsersTagsValue> UsersTagsValues { get; set; }
        public virtual DbSet<TextChatTracker> TextChatTrackers { get; set; }
        public virtual DbSet<TextChatTrackerStatus> TextChatTrackerStatuses { get; set; }
        public virtual DbSet<UsersChangesType> UsersChangesTypes { get; set; }
        public virtual DbSet<Notify> Notifies { get; set; }
        public virtual DbSet<NotifyMedium> NotifyMediums { get; set; }
        public virtual DbSet<MailsArchive> MailsArchives { get; set; }
    
        public virtual int Configuration_GetNewDeviceTag(ObjectParameter newDeviceTag)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_GetNewDeviceTag", newDeviceTag);
        }
    
        public virtual int Configuration_GetNewSessionTag(ObjectParameter newSessionTag)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_GetNewSessionTag", newSessionTag);
        }
    
        public virtual ObjectResult<ListedUser> ListedUsers_GetBy(Nullable<int> count, Nullable<int> belowId, Nullable<int> knows, Nullable<int> learns, string firstName, string lastName, Nullable<int> country, string location, Nullable<int> minAge, Nullable<int> maxAge, Nullable<int> tag)
        {
            var countParameter = count.HasValue ?
                new ObjectParameter("Count", count) :
                new ObjectParameter("Count", typeof(int));
    
            var belowIdParameter = belowId.HasValue ?
                new ObjectParameter("BelowId", belowId) :
                new ObjectParameter("BelowId", typeof(int));
    
            var knowsParameter = knows.HasValue ?
                new ObjectParameter("Knows", knows) :
                new ObjectParameter("Knows", typeof(int));
    
            var learnsParameter = learns.HasValue ?
                new ObjectParameter("Learns", learns) :
                new ObjectParameter("Learns", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var countryParameter = country.HasValue ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var minAgeParameter = minAge.HasValue ?
                new ObjectParameter("MinAge", minAge) :
                new ObjectParameter("MinAge", typeof(int));
    
            var maxAgeParameter = maxAge.HasValue ?
                new ObjectParameter("MaxAge", maxAge) :
                new ObjectParameter("MaxAge", typeof(int));
    
            var tagParameter = tag.HasValue ?
                new ObjectParameter("Tag", tag) :
                new ObjectParameter("Tag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListedUser>("ListedUsers_GetBy", countParameter, belowIdParameter, knowsParameter, learnsParameter, firstNameParameter, lastNameParameter, countryParameter, locationParameter, minAgeParameter, maxAgeParameter, tagParameter);
        }
    
        public virtual ObjectResult<ListedUser> ListedUsers_GetBy(Nullable<int> count, Nullable<int> belowId, Nullable<int> knows, Nullable<int> learns, string firstName, string lastName, Nullable<int> country, string location, Nullable<int> minAge, Nullable<int> maxAge, Nullable<int> tag, MergeOption mergeOption)
        {
            var countParameter = count.HasValue ?
                new ObjectParameter("Count", count) :
                new ObjectParameter("Count", typeof(int));
    
            var belowIdParameter = belowId.HasValue ?
                new ObjectParameter("BelowId", belowId) :
                new ObjectParameter("BelowId", typeof(int));
    
            var knowsParameter = knows.HasValue ?
                new ObjectParameter("Knows", knows) :
                new ObjectParameter("Knows", typeof(int));
    
            var learnsParameter = learns.HasValue ?
                new ObjectParameter("Learns", learns) :
                new ObjectParameter("Learns", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var countryParameter = country.HasValue ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var minAgeParameter = minAge.HasValue ?
                new ObjectParameter("MinAge", minAge) :
                new ObjectParameter("MinAge", typeof(int));
    
            var maxAgeParameter = maxAge.HasValue ?
                new ObjectParameter("MaxAge", maxAge) :
                new ObjectParameter("MaxAge", typeof(int));
    
            var tagParameter = tag.HasValue ?
                new ObjectParameter("Tag", tag) :
                new ObjectParameter("Tag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListedUser>("ListedUsers_GetBy", mergeOption, countParameter, belowIdParameter, knowsParameter, learnsParameter, firstNameParameter, lastNameParameter, countryParameter, locationParameter, minAgeParameter, maxAgeParameter, tagParameter);
        }
    
        public virtual int Mails_Archive(Nullable<int> userId, Nullable<long> mailId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var mailIdParameter = mailId.HasValue ?
                new ObjectParameter("MailId", mailId) :
                new ObjectParameter("MailId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Mails_Archive", userIdParameter, mailIdParameter);
        }
    
        public virtual ObjectResult<Mails_GetList_Result> Mails_GetList(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Mails_GetList_Result>("Mails_GetList", idParameter);
        }
    
        public virtual int Mails_Insert(Nullable<byte> regulationStatus, Nullable<int> fromId, Nullable<long> replyToMail, Nullable<int> toId, string subject, string message)
        {
            var regulationStatusParameter = regulationStatus.HasValue ?
                new ObjectParameter("RegulationStatus", regulationStatus) :
                new ObjectParameter("RegulationStatus", typeof(byte));
    
            var fromIdParameter = fromId.HasValue ?
                new ObjectParameter("FromId", fromId) :
                new ObjectParameter("FromId", typeof(int));
    
            var replyToMailParameter = replyToMail.HasValue ?
                new ObjectParameter("ReplyToMail", replyToMail) :
                new ObjectParameter("ReplyToMail", typeof(long));
    
            var toIdParameter = toId.HasValue ?
                new ObjectParameter("ToId", toId) :
                new ObjectParameter("ToId", typeof(int));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Mails_Insert", regulationStatusParameter, fromIdParameter, replyToMailParameter, toIdParameter, subjectParameter, messageParameter);
        }
    
        public virtual ObjectResult<TextChat_GetHistory_Result> TextChat_GetHistory(Nullable<int> count, string roomId, string visibilitiesCsv)
        {
            var countParameter = count.HasValue ?
                new ObjectParameter("Count", count) :
                new ObjectParameter("Count", typeof(int));
    
            var roomIdParameter = roomId != null ?
                new ObjectParameter("RoomId", roomId) :
                new ObjectParameter("RoomId", typeof(string));
    
            var visibilitiesCsvParameter = visibilitiesCsv != null ?
                new ObjectParameter("VisibilitiesCsv", visibilitiesCsv) :
                new ObjectParameter("VisibilitiesCsv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TextChat_GetHistory_Result>("TextChat_GetHistory", countParameter, roomIdParameter, visibilitiesCsvParameter);
        }
    }
}
