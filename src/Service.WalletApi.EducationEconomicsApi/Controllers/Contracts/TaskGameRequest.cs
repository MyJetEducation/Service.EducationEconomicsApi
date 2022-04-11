﻿using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationEconomicsApi.Controllers.Contracts
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}