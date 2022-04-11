﻿using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationEconomicsApi.Controllers.Contracts
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}