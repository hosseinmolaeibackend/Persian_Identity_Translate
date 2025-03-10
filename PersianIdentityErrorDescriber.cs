using Microsoft.AspNetCore.Identity;

namespace Persian_Identity_Translate
{
	public class PersianIdentityErrorDescriber : IdentityErrorDescriber
	{
		//email override and translate to persian
		public override IdentityError DuplicateEmail(string email)
		=> new IdentityError()
		{
			Code = nameof(DuplicateEmail),
			Description = $"{email} .ایمیل از قبل موجود هست"
		};
		public override IdentityError InvalidEmail(string? email)
		=> new IdentityError()
		{
			Code = nameof(InvalidEmail),
			Description = "این ایمیل معتبر نیست"
		};

		//user override and translate to persian
		public override IdentityError DuplicateUserName(string userName)
		=> new IdentityError()
		{
			Code = nameof(DuplicateUserName),
			Description = "این نام کاربری از قبل موجود است."
		};
		public override IdentityError InvalidUserName(string? userName)
		=> new IdentityError()
		{
			Code = nameof(InvalidUserName),
			Description = "این  نام کاربری معتبر نیست"
		};

		//password override and translate to persian
		public override IdentityError PasswordMismatch()
			=> new IdentityError()
			{
				Code = nameof(PasswordMismatch),
				Description = "عدم تطابق رمز عبور"
			};
		public override IdentityError PasswordRequiresDigit()
		=> new IdentityError()
		{
			Code = nameof(PasswordRequiresDigit),
			Description = "رمزعبور باید شامل عدد باشد"
		};
		public override IdentityError PasswordRequiresLower()
			=> new IdentityError()
			{
				Code = nameof(PasswordRequiresLower),
				Description = "رمزعبور باید شامل حروف کوچک باشد"
			};
		public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
			=> new IdentityError()
			{
				Code = nameof(PasswordRequiresUniqueChars),
				Description = "رمز عبور باید شامل حروف منحصر بفرد @ # $ ... باشد"
			};
		public override IdentityError PasswordRequiresNonAlphanumeric()
		=> new IdentityError()
		{
			Code = nameof(PasswordRequiresNonAlphanumeric),
			Description = "رمز عبور شما باید غیر حروف الفبا نیز شامل شود"
		};
		public override IdentityError PasswordRequiresUpper()
		=> new IdentityError()
		{
			Code= nameof(PasswordRequiresUpper),
			Description="رمز عبور باید شامل حروف بزرگ باشد"
		};
		public override IdentityError PasswordTooShort(int length)
		=> new IdentityError()
		{
			Code = nameof(PasswordTooShort),
			Description = $"در تعداد کارکتر ها مشکل وجود دارد"
		};
		public override IdentityError UserAlreadyHasPassword()
		=> new IdentityError()
		{
			Code = nameof(UserAlreadyHasPassword),
			Description = "کاربر از قبل رمز عبور دارد"
		};

		//role override and translate to persian
		public override IdentityError UserAlreadyInRole(string role)
		=> new IdentityError()
		{
			Code = nameof(UserAlreadyInRole),
			Description = $"کاربر در {role} نقش وجود دارد"
		};
		public override IdentityError UserNotInRole(string role)
		=> new IdentityError()
		{
			Code = nameof(UserNotInRole),
			Description = $"{role} وجود ندارد کاربر در این نفش "
		};
		public override IdentityError DuplicateRoleName(string role)
		=> new IdentityError()
		{
			Code = nameof(DuplicateRoleName),
			Description = $"این {role} نقش وجود دارد"
		};
		public override IdentityError InvalidRoleName(string? role)
		=> new IdentityError()
		{
			Code = nameof(InvalidRoleName),
			Description = $"این {role} نقش معتبر نیست"
		};

		//other override translate to persian
		public override IdentityError RecoveryCodeRedemptionFailed()
		=> new IdentityError()
		{
			Code = nameof(RecoveryCodeRedemptionFailed),
			Description = "بازیابی کد  ناموفق بود"
		};

		public override IdentityError UserLockoutNotEnabled()
		=> new IdentityError()
		{
			Code = nameof(UserLockoutNotEnabled),
			Description = "قفل کاربر فعال نیست"
		};
		public override IdentityError LoginAlreadyAssociated()
		=> new IdentityError()
		{
			Code = nameof(LoginAlreadyAssociated),
			Description = "ورود به سیستم در حال حاضر مرتبط است"
		};
		public override IdentityError InvalidToken()
		=> new IdentityError()
		{
			Code = nameof(InvalidToken),
			Description = "کد معتبر نیست"
		};
		public override IdentityError DefaultError()
		=> new IdentityError()
		{
			Code = nameof(DefaultError),
			Description = "خطای غیر منتظره ای در سیستم احراز هویت پیش آمده"
		};

		public override IdentityError ConcurrencyFailure()
		=> new IdentityError()
		{
			Code = nameof(ConcurrencyFailure),
			Description = "شکست در همزمانی خوش‌بینانه، شیء تغییر یافته است."
		};
	}
}
