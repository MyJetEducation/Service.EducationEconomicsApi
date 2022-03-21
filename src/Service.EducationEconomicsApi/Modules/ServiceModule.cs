using Autofac;
using Microsoft.Extensions.Logging;
using Service.Core.Client.Services;
using Service.TutorialEconomics.Client;

namespace Service.EducationEconomicsApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterTutorialEconomicsClient(Program.Settings.EducationFlowServiceUrl, Program.LogFactory.CreateLogger(typeof(TutorialEconomicsClientFactory)));

			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();

			builder.Register(context => new EncoderDecoder(Program.EncodingKey))
				.As<IEncoderDecoder>()
				.SingleInstance();
		}
	}
}
