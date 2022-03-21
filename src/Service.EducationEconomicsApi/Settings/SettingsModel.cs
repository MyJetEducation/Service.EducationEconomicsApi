using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationEconomicsApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationEconomicsApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationEconomicsApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationEconomicsApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationEconomicsApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}
