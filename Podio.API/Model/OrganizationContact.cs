using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class OrganizationContact : Profile
	{


		[DataMember(Name = "org_id", IsRequired=false)]
		public int? OrgId { get; set; }


		[DataMember(Name = "attention", IsRequired=false)]
		public string Attention { get; set; }


	}
}

