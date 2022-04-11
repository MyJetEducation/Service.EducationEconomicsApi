using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationEconomicsApi.Controllers.Contracts
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}