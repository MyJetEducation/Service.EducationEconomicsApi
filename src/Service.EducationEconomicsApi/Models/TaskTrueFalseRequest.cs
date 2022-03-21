using System.ComponentModel.DataAnnotations;

namespace Service.EducationEconomicsApi.Models
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}