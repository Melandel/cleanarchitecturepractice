using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection ConfigureModule_GetMessageData(this IServiceCollection collection)
		{
			return collection
				.AddSingleton<MessageGateway, MessageGatewayImpl>();
		}
	}
}
