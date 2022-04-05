using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationEconomicsApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationEconomicsApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationEconomicsApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationEconomicsApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationEconomicsApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("EducationEconomicsApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationEconomicsApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationEconomicsApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("EducationEconomicsApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationEconomicsApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}