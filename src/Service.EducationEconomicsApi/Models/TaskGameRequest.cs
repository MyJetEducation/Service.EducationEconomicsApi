using System.ComponentModel.DataAnnotations;

namespace Service.EducationEconomicsApi.Models
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}