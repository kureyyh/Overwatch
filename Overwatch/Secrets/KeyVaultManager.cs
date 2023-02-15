using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.Secrets
{
    public class KeyVaultManager : IKeyVaultManager
    {

        private readonly SecretClient _secretClient;

        public KeyVaultManager(SecretClient secretClient)
        {
            _secretClient = secretClient;
        }


        public async Task<string> GetSecret(string secretName)
        {
            try
            {
                //var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());



                KeyVaultSecret keyValueSecret = await _secretClient.GetSecretAsync(secretName);
                return keyValueSecret.Value;
            }
            catch
            {
                throw;
            }

        }

    }
}
