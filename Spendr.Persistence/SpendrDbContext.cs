using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spendr.Domain.Entities;

namespace Spendr.Persistence
{
    public class SpendrDbContext : IdentityDbContext<User>
    {
        public SpendrDbContext(DbContextOptions<SpendrDbContext>options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardTransaction> CardTransactions { get; set; }
        public DbSet<CardTransactionCategory> CardTransactionCategories { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletTransaction> WalletTransactions { get; set; }
        public DbSet<WalletTransactionCategory> WalletTransactionCategories { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<MerchantAddress> MerchantAddresses { get; set; }
        public DbSet<MerchantContact> MerchantContacts{ get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserAddress> UserAddresses{ get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfigurationsFromAssembly(typeof(SpendrDbContext).Assembly);

            builder.Entity<Card>()
                .HasOne(e => e.User)
                .WithMany(e => e.Cards)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<CardTransaction>()
                .HasOne(e => e.Card)
                .WithMany(e => e.CardTransactions)
                .HasForeignKey(e => e.CardId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<Wallet>()
                 .HasOne(e => e.User)
                 .WithOne(e => e.Wallet)
                 .HasForeignKey<Wallet>(e => e.UserId)
                 .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<WalletTransaction>()
                .HasOne(e => e.Wallet)
                .WithMany(e => e.WalletTransactions)
                .HasForeignKey(e => e.WalletId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<UserAddress>()
                .HasOne(e => e.User)
                .WithOne(e => e.UserAddress)
                .HasForeignKey<UserAddress>(e => e.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<UserContact>()
            .HasOne(e => e.User)
            .WithOne(e => e.UserContact)
            .HasForeignKey<UserContact>(e => e.UserId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<MerchantAddress>()
            .HasOne(e => e.Merchant)
            .WithOne(e => e.MerchantAddress)
            .HasForeignKey<MerchantAddress>(e => e.MerchantId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<MerchantContact>()
            .HasOne(e => e.Merchant)
            .WithOne(e => e.MerchantContact)
            .HasForeignKey<MerchantContact>(e => e.MerchantId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<CardTransaction>()
                .HasOne(e => e.CardTransactionCategory)
                .WithMany(e => e.CardTransaction)
                .HasForeignKey(e => e.CardTransactionCategoryId);

            builder.Entity<WalletTransaction>()
                .HasOne(e => e.walletTransactionCategory)
                .WithMany(e => e.WalletTransactions)
                .HasForeignKey(e => e.WalletTransactionCategoryId);
        }

    }
}
