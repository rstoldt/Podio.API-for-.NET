using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class User
	{


		[DataMember(Name = "user_id", IsRequired=false)]
		public int? UserId { get; set; }


		[DataMember(Name = "mail", IsRequired=false)]
		public string Mail { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "locale", IsRequired=false)]
		public string Locale { get; set; }


		[DataMember(Name = "timezone", IsRequired=false)]
		public string Timezone { get; set; }


		[DataMember(Name = "password", IsRequired=false)]
		public string Password { get; set; }


		[DataMember(Name = "old_password", IsRequired=false)]
		public string OldPassword { get; set; }


		[DataMember(Name = "new_password", IsRequired=false)]
		public string NewPassword { get; set; }


		[DataMember(Name = "flags", IsRequired=false)]
		public string[] Flags { get; set; }


		[DataMember(Name = "betas", IsRequired=false)]
		public string[] Betas { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime? CreatedOn { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "avatar", IsRequired=false)]
		public int? Avatar { get; set; }


		[DataMember(Name = "profile_id", IsRequired=false)]
		public int? ProfileId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "landing", IsRequired=false)]
		public string Landing { get; set; }


		[DataMember(Name = "referrer", IsRequired=false)]
		public string Referrer { get; set; }


		[DataMember(Name = "internal", IsRequired=false)]
		public Dictionary<string,object> Internal { get; set; }


		[DataMember(Name = "marketo_cookie", IsRequired=false)]
		public string MarketoCookie { get; set; }


		[DataMember(Name = "profile", IsRequired=false)]
		public Contact Profile { get; set; }


		[DataMember(Name = "mails", IsRequired=false)]
		public List<UserMail> Mails { get; set; }


	}
}

