using System;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using MernisServiceReference;

namespace GameStoreDemo.Adapters
{
    public class MernisAdapter:IUserCheckService
    {
        public bool ChechIfRealUser(User user)
        {
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result= client.TCKimlikNoDogrulaAsync(user.NationalityId,user.FirstName, user.LastName, user.DateOfYear).Result.Body.TCKimlikNoDogrulaResult;

            return result;
        }
    }
}