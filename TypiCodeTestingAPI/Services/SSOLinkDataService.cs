using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using Raven.Embedded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypiCodeTestingAPI.Data;

namespace TypiCodeTestingAPI.Services
{
    public class SSOLinkDataService : ISSOLinkDataService
    {
        public async Task<IEnumerable<SSOLink>> GetSSOLinks()
        {
            var store = EmbeddedServer.Instance.GetDocumentStore("Database");
            using (IDocumentSession Session = store.OpenSession())
            {
                List<SSOLink> ssolinks = Session
                    .Query<SSOLink>()
                    .ToList();
                return ssolinks;

            }
        }
    }
}
