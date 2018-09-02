﻿using System.Data.Entity;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Storage;

namespace NFive.SessionManager.Storage
{
	public class StorageContext : EFContext<StorageContext>
	{
		public DbSet<Session> Sessions { get; set; }

		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<User>().HasIndex(u => u.SteamId).IsUnique();
		}
	}
}
