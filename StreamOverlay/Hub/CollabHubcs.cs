using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StreamOverlay
{
    public class CollabHubcs : Hub
    {
      public async Task SetAnnotationSync(AnnotationSync annotationSync)
        {
            await Clients.All.ReceiveAnnotationSync(annotationSync);
        }

    }
    public class AnnotationSync
    {
        public string User { get; set; }
        public string AnnotationJson { get; set; }
    }
}