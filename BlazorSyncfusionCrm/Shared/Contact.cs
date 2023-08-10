using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorSyncfusionCrm.Shared
{
	public class Contact
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Required]
		public string NickName { get; set; }
		public string Place { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public double? Latitude { get; set; }
		public double? Longtitude { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.Now;
		public DateTime? DateUpdated { get; set; }
		public DateTime? DateDeleted { get; set; }
		[JsonIgnore]
		public List<Note> Notes { get; set; } = new List<Note>();
    }
}

