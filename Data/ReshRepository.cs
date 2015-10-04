using System;
using Data.ReshService;

namespace Data
{
    public class ReshRepository : IReshRepository
    {
        public ReshUnit Get(int id)
        {
            using (var reshServiceClient = new ReshServiceClient())
            {
                reshServiceClient.ClientCredentials.UserName.UserName = "webservice";
                var reshUnit = reshServiceClient.GetReshUnit(id, false, true, null);
                reshServiceClient.Close();
                return reshUnit;
            }
        }
    }
}
