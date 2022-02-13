namespace Domain
{
	public class User : SeedWork.Entity,
		SeedWork.IEntityHasIsActive,
		SeedWork.IEntityHasIsSystemic,
		SeedWork.IEntityHasIsDeletable,
		SeedWork.IEntityHasIsUpdatable
	{
		#region Constant(s)
		public const int UsernameMaxLength = 20;
		public const int LastNameMaxLength = 20;
		public const int FirstNameMaxLength = 30;
		public const int PasswordMaxLength = 128;
		public const int NationalCodeMaxLength = 10;

		public const int EmailAddressMaxLength = 254;
		public const int EmailAddressVerificationKeyMaxLength = 64;

		public const int CellPhoneNumberMaxLength = 14;
		public const int CellPhoneNumberVerificationKeyMaxLength = 10;
		#endregion /Constant(s)

		#region Static(s)
		#endregion /Static(s)

		#region Constructor
		public User() : base()
		{
			IsDeletable = true;
			IsUpdatable = true;

			SetUpdateDateTime();
			SetEmailAddressVerificationKey();
		}
		#endregion /Constructor

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsActive))]
		public bool IsActive { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsSystemic))]
		public bool IsSystemic { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsDeletable))]
		public bool IsDeletable { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsUpdatable))]
		public bool IsUpdatable { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsProfilePublic))]
		public bool IsProfilePublic { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsEmailAddressVerified))]
		public bool IsEmailAddressVerified { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsNationalCodeVerified))]
		public bool IsNationalCodeVerified { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsCellPhoneNumberVerified))]
		public bool IsCellPhoneNumberVerified { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.UpdateDateTime))]
		public System.DateTime UpdateDateTime { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.LastName))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: LastNameMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string LastName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.FirstName))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: FirstNameMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string FirstName { get; set; }
		// **********

		// **********
		private string _username;

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Username))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: UsernameMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				//value =
				//	Dtat.String.Fix(value);

				if (value == null)
				{
					_username = null;
					return;
				}

				value =
					value.Replace(" ", string.Empty);

				_username = value;
			}
		}
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EmailAddress))]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: EmailAddressMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EmailAddressVerificationKey))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: EmailAddressVerificationKeyMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string EmailAddressVerificationKey { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.CellPhoneNumber))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: CellPhoneNumberMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string CellPhoneNumber { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.CellPhoneNumberVerificationKey))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: CellPhoneNumberVerificationKeyMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string CellPhoneNumberVerificationKey { get; private set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.NationalCode))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: NationalCodeMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string NationalCode { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Password))]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: PasswordMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validations),
			ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]
		public string Description { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.OwnerDescription))]
		public string OwnerDescription { get; set; }
		// **********

		private void SetEmailAddressVerificationKey()
		{
			string result =
				System.Guid.NewGuid().ToString()
				+
				System.Guid.NewGuid().ToString()
				;

			result =
				result.Replace("-", string.Empty);

			EmailAddressVerificationKey = result;
		}

		public void SetUpdateDateTime()
		{
			UpdateDateTime =
				SeedWork.Utility.Now;
		}
	}
}
