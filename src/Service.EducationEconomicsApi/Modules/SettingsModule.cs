using Autofac;

namespace Service.EducationEconomicsApi.Modules
{
	public class SettingsModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterInstance(Program.Settings).AsSelf().SingleInstance();
		}
	}
}