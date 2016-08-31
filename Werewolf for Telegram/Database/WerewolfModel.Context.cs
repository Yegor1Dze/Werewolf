﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WWContext : DbContext
    {
        public WWContext()
            : base(Internal.Default.DBConnectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameKill> GameKills { get; set; }
        public virtual DbSet<GamePlayer> GamePlayers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<KillMethod> KillMethods { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<NotifyGame> NotifyGames { get; set; }
        public virtual DbSet<v_NonDefaultGroups> v_NonDefaultGroups { get; set; }
        public virtual DbSet<v_PreferredGroups> v_PreferredGroups { get; set; }
        public virtual DbSet<v_WaitList> v_WaitList { get; set; }
        public virtual DbSet<GlobalStat> GlobalStats { get; set; }
        public virtual DbSet<PlayerStat> PlayerStats { get; set; }
        public virtual DbSet<GroupStat> GroupStats { get; set; }
        public virtual DbSet<DailyCount> DailyCounts { get; set; }
        public virtual DbSet<v_IdleKill24HoursMain> v_IdleKill24HoursMain { get; set; }
        public virtual DbSet<v_PublicGroups> v_PublicGroups { get; set; }
        public virtual DbSet<GlobalBan> GlobalBans { get; set; }
        public virtual DbSet<v_InactivePlayersMain> v_InactivePlayersMain { get; set; }
        public virtual DbSet<BotStatu> BotStatus { get; set; }
        public virtual DbSet<ContestTerm> ContestTerms { get; set; }
    
        public virtual ObjectResult<getPlayTime_Result> getPlayTime(Nullable<int> playerCount)
        {
            var playerCountParameter = playerCount.HasValue ?
                new ObjectParameter("playerCount", playerCount) :
                new ObjectParameter("playerCount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPlayTime_Result>("getPlayTime", playerCountParameter);
        }
    
        public virtual ObjectResult<getRoles_Result> getRoles(string groupName)
        {
            var groupNameParameter = groupName != null ?
                new ObjectParameter("groupName", groupName) :
                new ObjectParameter("groupName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getRoles_Result>("getRoles", groupNameParameter);
        }
    
        public virtual ObjectResult<PlayerMostKilled_Result> PlayerMostKilled(Nullable<int> pid)
        {
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlayerMostKilled_Result>("PlayerMostKilled", pidParameter);
        }
    
        public virtual ObjectResult<PlayerMostKilledBy_Result> PlayerMostKilledBy(Nullable<int> pid)
        {
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlayerMostKilledBy_Result>("PlayerMostKilledBy", pidParameter);
        }
    
        public virtual ObjectResult<PlayerRoles_Result> PlayerRoles(Nullable<int> pid)
        {
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlayerRoles_Result>("PlayerRoles", pidParameter);
        }
    
        public virtual ObjectResult<GlobalDay1Death_Result1> GlobalDay1Death()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GlobalDay1Death_Result1>("GlobalDay1Death");
        }
    
        public virtual ObjectResult<GlobalDay1Lynch_Result1> GlobalDay1Lynch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GlobalDay1Lynch_Result1>("GlobalDay1Lynch");
        }
    
        public virtual ObjectResult<GlobalNight1Death_Result1> GlobalNight1Death()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GlobalNight1Death_Result1>("GlobalNight1Death");
        }
    
        public virtual ObjectResult<GlobalSurvivor_Result1> GlobalSurvivor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GlobalSurvivor_Result1>("GlobalSurvivor");
        }
    
        public virtual ObjectResult<GroupDay1Death_Result1> GroupDay1Death(Nullable<long> groupid)
        {
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GroupDay1Death_Result1>("GroupDay1Death", groupidParameter);
        }
    
        public virtual ObjectResult<GroupDay1Lynch_Result1> GroupDay1Lynch(Nullable<long> groupid)
        {
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GroupDay1Lynch_Result1>("GroupDay1Lynch", groupidParameter);
        }
    
        public virtual ObjectResult<GroupNight1Death_Result1> GroupNight1Death(Nullable<long> groupid)
        {
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GroupNight1Death_Result1>("GroupNight1Death", groupidParameter);
        }
    
        public virtual ObjectResult<GroupSurvivor_Result1> GroupSurvivor(Nullable<long> groupid)
        {
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GroupSurvivor_Result1>("GroupSurvivor", groupidParameter);
        }
    
        public virtual ObjectResult<getDailyCounts_Result> getDailyCounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDailyCounts_Result>("getDailyCounts");
        }
    
        public virtual ObjectResult<Nullable<int>> GetIdleKills24Hours(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIdleKills24Hours", useridParameter);
        }
    }
}
