using System.ComponentModel.DataAnnotations;

namespace Service.EducationEconomicsApi.Models
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}