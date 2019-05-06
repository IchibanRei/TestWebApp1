using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EnvironmentRepository : IEnvironmentRepository, IEnumerable, IEnumerator
    {
        //private static string baseUrl = "https://dashboardserverstatus.azurewebsites.net//api/v1/Dashboard/";
        //public async Task<IEnumerable<Environment>> GetAllEnvironments()
        //{
        //    var envJson = await GetStringAsync(baseUrl);
        //    var env = JsonConvert.DeserializeObject<Environment>(envJson);
        //    return env;
        //}

        //public async Task<Environment> GetEnvByName(string envName)
        //{
        //    var envJson = await GetStringAsync(baseUrl + envName);
        //    var env = JsonConvert.DeserializeObject<Environment>(envJson);
        //    return env;
        //}

        //private static async Task<string> GetStringAsync(string baseUrl)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        return await httpClient.GetStringAsync(baseUrl);
        //    }
        //}

        private List<Environment> _environments;
        int position = -1;

        public EnvironmentRepository()
        {
            if(_environments == null)
            {
                InitializeEnvironments();
            }
        }

        private void InitializeEnvironments()
        {
            _environments = new List<Environment>
            {
                new Environment {Name = "Smoketest3", ServerPool = "Calc", ServerName= "TestVM1", PoolType = "CalcPool", Build = "Rel3.5_20180402.1", Date = "05-02-2019", Status = "ServerOnline"},
                new Environment {Name = "Smoketest3", ServerPool = "Commnon", ServerName= "TestVM2", PoolType = "CommonPool", Build = "Rel3.5_20180402.1", Date = "05-02-2019", Status = "ServerOnline"},
                new Environment {Name = "Smoketest3", ServerPool = "Batch", ServerName= "TestVM3", PoolType = "BatchPool", Build = "Rel3.5_20180401.1", Date = "05-01-2019", Status = "ServerOnline"},
                new Environment {Name = "Smoketest4", ServerPool = "Common", ServerName= "TestVM4", PoolType = "CommonPool", Build = "Rel3.5_20180402.1", Date = "05-02-2019", Status = "ServerOnline"},
                new Environment {Name = "Smoketest4", ServerPool = "Calc", ServerName= "TestVM5", PoolType = "CalcPool", Build = "Rel3.5_20180402.1", Date = "05-02-2019", Status = "ServerOnline"},
                new Environment {Name = "Smoketest4", ServerPool = "Calc", ServerName= "TestVM1", PoolType = "CalcPool", Build = "Rel3.5_20180402.1", Date = "05-02-2019", Status = "ServerOffline"},
            };
        }

        public IEnumerable<Environment> GetAllEnvironments()
        {
            return _environments;
        }

        public Environment GetEnvironmentByName(string Name)
        {
            return _environments.FirstOrDefault(e => e.Name == Name);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _environments.Count);
        }

        public void Reset()
        { position = 0; }

        public object Current
        {
            get
            {
                return _environments[position];
            }
        }
    }
}
