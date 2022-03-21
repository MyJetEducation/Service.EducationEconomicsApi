using System.ComponentModel.DataAnnotations;

namespace Service.EducationEconomicsApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}