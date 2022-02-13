namespace Persistence.Aggregates.Users
{
	internal class User :
		object, Microsoft.EntityFrameworkCore
		.IEntityTypeConfiguration<Domain.User>
	{
		public User() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders
			.EntityTypeBuilder<Domain.User> builder)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			builder
				.Property(current => current.Username)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.Username })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.EmailAddress)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.EmailAddress })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.CellPhoneNumber)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.CellPhoneNumber })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.NationalCode)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.NationalCode })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.CellPhoneNumberVerificationKey)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.CellPhoneNumberVerificationKey })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.EmailAddressVerificationKey)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.EmailAddressVerificationKey })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.Password)
				.IsUnicode(unicode: false)
				;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//builder
			//	.HasMany(current => current.Memberships)
			//	.WithOne(other => other.User)
			//	.IsRequired(required: true)
			//	.HasForeignKey(other => other.UserId)
			//	.OnDelete(deleteBehavior:
			//		Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
			//	;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//var user =
			//	new Domain.Aggregates.Users.User
			//	{
			//		Id =
			//			Domain.Aggregates.Users.User.ZeusUserId,

			//		IsActive = true,
			//		IsSystemic = true,
			//		IsDeletable = false,
			//		IsProfilePublic = true,
			//		IsEmailAddressVerified = true,
			//		IsNationalCodeVerified = true,
			//		IsCellPhoneNumberVerified = true,

			//		LastName = "تصدیقی",
			//		FirstName = "داریوش",
			//		NationalCode = "0055894216",
			//		Username = "DariushTasdighi",
			//		CellPhoneNumber = "00989121087461",
			//		EmailAddress = "DariushT@GMail.com",

			//		Password =
			//			BCrypt.Net.BCrypt.HashPassword(inputKey: "Hello12345!"),

			//		Description = null,
			//		OwnerDescription = null,

			//		Memberships = null,
			//		UserActivityLogs = null,
			//		UserApplicationTokens = null,
			//	};

			//builder.HasData(user);
			// **************************************************
			// **************************************************
			// **************************************************
		}
	}
}
