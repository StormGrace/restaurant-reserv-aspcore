using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;

namespace rest_reserv.Data
{
  public partial class RestDbContext : DbContext
  {
    public RestDbContext()
    {
    }

    public RestDbContext(DbContextOptions<RestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activity { get; set; }
    public virtual DbSet<ActivityType> ActivityType { get; set; }
    public virtual DbSet<Inbox> Inbox { get; set; }
    public virtual DbSet<Listing> Listing { get; set; }
    public virtual DbSet<ListingLog> ListingLog { get; set; }
    public virtual DbSet<Message> Message { get; set; }
    public virtual DbSet<MessageType> MessageType { get; set; }
    public virtual DbSet<Review> Review { get; set; }
    public virtual DbSet<ReviewActivity> ReviewActivity { get; set; }
    public virtual DbSet<SavedListing> SavedListing { get; set; }
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<UserLog> UserLog { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Activity>(entity =>
      {
        entity.ToTable("activity");

        entity.HasIndex(e => e.ActionTypeId)
            .HasName("fk_Action_Action_Type1_idx");

        entity.HasIndex(e => e.UserId)
            .HasName("fk_Action_User1_idx");

        entity.Property(e => e.ActivityId)
            .HasColumnName("activity_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.ActionTypeId)
            .HasColumnName("action_type_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.DateCreated)
            .HasColumnName("date_created")
            .HasColumnType("datetime");

        entity.Property(e => e.UserId)
            .HasColumnName("user_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.ActionType)
            .WithMany(p => p.Activity)
            .HasForeignKey(d => d.ActionTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Action_Action_Type1");

        entity.HasOne(d => d.User)
            .WithMany(p => p.Activity)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Action_User1");
      });

      modelBuilder.Entity<ActivityType>(entity =>
      {
        entity.ToTable("activity_type");

        entity.Property(e => e.ActivityTypeId)
            .HasColumnName("activity_type_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Type)
            .IsRequired()
            .HasColumnName("type")
            .HasColumnType("varchar(30)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");
      });

      modelBuilder.Entity<Inbox>(entity =>
      {
        entity.ToTable("inbox");

        entity.HasIndex(e => e.MessageId)
            .HasName("fk_Inbox_Message1_idx");

        entity.Property(e => e.InboxId)
            .HasColumnName("inbox_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.MessageCount)
            .HasColumnName("message_count")
            .HasColumnType("int(11)");

        entity.Property(e => e.MessageId)
            .HasColumnName("message_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Message)
            .WithMany(p => p.Inbox)
            .HasForeignKey(d => d.MessageId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Inbox_Message1");
      });

      modelBuilder.Entity<Listing>(entity =>
      {
        entity.ToTable("listing");

        entity.Property(e => e.ListingId)
            .HasColumnName("listing_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.ReviewCount)
            .HasColumnName("review_count")
            .HasColumnType("int(11)");
      });

      modelBuilder.Entity<ListingLog>(entity =>
      {
        entity.HasKey(e => e.ListingHistoryId)
            .HasName("PRIMARY");

        entity.ToTable("listing_log");

        entity.HasIndex(e => e.ListingId)
            .HasName("fk_Listing_History_Listing1_idx");

        entity.HasIndex(e => new { e.ListingId, e.Version })
            .HasName("listing_ID & version")
            .IsUnique();

        entity.Property(e => e.ListingHistoryId)
            .HasColumnName("listing_history_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Active).HasColumnName("active");

        entity.Property(e => e.DateCreated)
            .HasColumnName("date_created")
            .HasColumnType("datetime");

        entity.Property(e => e.ListingDescription)
            .IsRequired()
            .HasColumnName("listing_description")
            .HasColumnType("varchar(300)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.ListingId)
            .HasColumnName("listing_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.ListingImg)
            .IsRequired()
            .HasColumnName("listing_img")
            .HasColumnType("blob");

        entity.Property(e => e.ListingPhone)
            .IsRequired()
            .HasColumnName("listing_phone")
            .HasColumnType("varchar(45)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.ListingRating)
            .HasColumnName("listing_rating")
            .HasColumnType("decimal(10,0)");

        entity.Property(e => e.ListingSite)
            .IsRequired()
            .HasColumnName("listing_site")
            .HasColumnType("varchar(45)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.ListingTitle)
            .IsRequired()
            .HasColumnName("listing_title")
            .HasColumnType("varchar(80)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.Version)
            .HasColumnName("version")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Listing)
            .WithMany(p => p.ListingLog)
            .HasForeignKey(d => d.ListingId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Listing_History_Listing1");
      });

      modelBuilder.Entity<Message>(entity =>
      {
        entity.ToTable("message");

        entity.HasIndex(e => e.MessageTypeId)
            .HasName("fk_Message_Message_Type1_idx");

        entity.Property(e => e.MessageId)
            .HasColumnName("message_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Active).HasColumnName("active");

        entity.Property(e => e.DateCreated)
            .HasColumnName("date_created")
            .HasColumnType("datetime");

        entity.Property(e => e.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasColumnType("varchar(254)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.MessageTypeId)
            .HasColumnName("message_type_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Title)
            .IsRequired()
            .HasColumnName("title")
            .HasColumnType("varchar(254)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.HasOne(d => d.MessageType)
            .WithMany(p => p.Message)
            .HasForeignKey(d => d.MessageTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Message_Message_Type1");
      });

      modelBuilder.Entity<MessageType>(entity =>
      {
        entity.ToTable("message_type");

        entity.Property(e => e.MessageTypeId)
            .HasColumnName("message_type_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Type)
            .IsRequired()
            .HasColumnName("type")
            .HasColumnType("varchar(30)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");
      });

      modelBuilder.Entity<Review>(entity =>
      {
        entity.ToTable("review");

        entity.HasIndex(e => e.ListingId)
            .HasName("fk_Review_Listing1_idx");

        entity.HasIndex(e => e.UserId)
            .HasName("fk_Review_User1_idx");

        entity.Property(e => e.ReviewId)
            .HasColumnName("review_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Active).HasColumnName("active");

        entity.Property(e => e.DateCreated)
            .HasColumnName("date_created")
            .HasColumnType("datetime");

        entity.Property(e => e.DateVisited)
            .HasColumnName("date_visited")
            .HasColumnType("datetime");

        entity.Property(e => e.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasColumnType("varchar(600)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.Likes)
            .HasColumnName("likes")
            .HasColumnType("int(11)");

        entity.Property(e => e.ListingId)
            .HasColumnName("listing_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Rating)
            .HasColumnName("rating")
            .HasColumnType("tinyint(5)");

        entity.Property(e => e.Title)
            .IsRequired()
            .HasColumnName("title")
            .HasColumnType("varchar(80)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.UserId)
            .HasColumnName("user_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Listing)
            .WithMany(p => p.Review)
            .HasForeignKey(d => d.ListingId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Review_Listing1");

        entity.HasOne(d => d.User)
            .WithMany(p => p.Review)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Review_User1");
      });

      modelBuilder.Entity<ReviewActivity>(entity =>
      {
        entity.HasKey(e => e.ActivityLogId)
            .HasName("PRIMARY");

        entity.ToTable("review_activity");

        entity.HasIndex(e => e.ActivityId)
            .HasName("fk_Action_Log_Action1_idx");

        entity.HasIndex(e => e.ReviewId)
            .HasName("fk_Action_Log_Review1_idx");

        entity.Property(e => e.ActivityLogId)
            .HasColumnName("activity_log_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.ActivityId)
            .HasColumnName("activity_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.ReviewId)
            .HasColumnName("review_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Activity)
            .WithMany(p => p.ReviewActivity)
            .HasForeignKey(d => d.ActivityId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Action_Log_Action1");

        entity.HasOne(d => d.Review)
            .WithMany(p => p.ReviewActivity)
            .HasForeignKey(d => d.ReviewId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Action_Log_Review1");
      });

      modelBuilder.Entity<SavedListing>(entity =>
      {
        entity.ToTable("saved_listing");

        entity.HasIndex(e => e.ListingId)
            .HasName("fk_Saved_Listing_Listing1_idx");

        entity.HasIndex(e => e.UserId)
            .HasName("fk_Saved_Listing_User1_idx");

        entity.Property(e => e.SavedListingId)
            .HasColumnName("saved_listing_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Active).HasColumnName("active");

        entity.Property(e => e.ListingId)
            .HasColumnName("listing_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.UserId)
            .HasColumnName("user_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Listing)
            .WithMany(p => p.SavedListing)
            .HasForeignKey(d => d.ListingId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Saved_Listing_Listing1");

        entity.HasOne(d => d.User)
            .WithMany(p => p.SavedListing)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Saved_Listing_User1");
      });

      modelBuilder.Entity<User>(entity =>
      {
        entity.ToTable("user");

        entity.HasIndex(e => e.InboxId)
            .HasName("fk_User_Inbox1_idx");

        entity.Property(e => e.UserId)
            .HasColumnName("user_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.InboxId)
            .HasColumnName("inbox_ID")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.Inbox)
            .WithMany(p => p.User)
            .HasForeignKey(d => d.InboxId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_User_Inbox1");
      });

      modelBuilder.Entity<UserLog>(entity =>
      {
        entity.HasKey(e => e.UserHistoryId)
            .HasName("PRIMARY");

        entity.ToTable("user_log");

        entity.HasIndex(e => e.UserId)
            .HasName("fk_User_History_User1_idx");

        entity.HasIndex(e => new { e.UserId, e.Version })
            .HasName("user_ID & version")
            .IsUnique();

        entity.Property(e => e.UserHistoryId)
            .HasColumnName("user_history_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Active).HasColumnName("active");

        entity.Property(e => e.DateCreated)
            .HasColumnName("date_created")
            .HasColumnType("datetime");

        entity.Property(e => e.Email)
            .IsRequired()
            .HasColumnName("email")
            .HasColumnType("varchar(255)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.FirstName)
            .IsRequired()
            .HasColumnName("first_name")
            .HasColumnType("varchar(50)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.LastName)
            .IsRequired()
            .HasColumnName("last_name")
            .HasColumnType("varchar(50)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.Password)
            .IsRequired()
            .HasColumnName("password")
            .HasColumnType("varchar(400)")
            .HasCharSet("utf8mb4")
            .HasCollation("utf8mb4_0900_ai_ci");

        entity.Property(e => e.ProfileImg)
            .IsRequired()
            .HasColumnName("profile_img")
            .HasColumnType("blob");

        entity.Property(e => e.UserId)
            .HasColumnName("user_ID")
            .HasColumnType("int(11)");

        entity.Property(e => e.Version)
            .HasColumnName("version")
            .HasColumnType("int(11)");

        entity.HasOne(d => d.User)
            .WithMany(p => p.UserLog)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_User_History_User1");
      });

      base.OnModelCreating(modelBuilder);

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
