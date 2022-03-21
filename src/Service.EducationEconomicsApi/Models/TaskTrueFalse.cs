using System.ComponentModel.DataAnnotations;

namespace Service.EducationEconomicsApi.Models
{
	public class TaskTrueFalse
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public bool Value { get; set; }
	}
}