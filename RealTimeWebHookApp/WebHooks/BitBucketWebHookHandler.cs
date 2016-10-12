using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using RealTimeWebHookApp.Helpers;

namespace RealTimeWebHookApp.WebHooks
{
    public class BitBucketWebHookHandler : WebHookHandler
    {
        public BitBucketWebHookHandler()
        {
            
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            if (Common.IsBitBucketReceiver(receiver))
            {
                var dataJObject = context.GetDataOrDefault<JObject>();
                var action = context.Actions.First();

                var processActivities = new ProcessActivities(dataJObject, action);
                processActivities.Process();
            }

            return Task.FromResult(true);
        }
    }
}