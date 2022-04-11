using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationEconomicsApi.Controllers.Contracts
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}