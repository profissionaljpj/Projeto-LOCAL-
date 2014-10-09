using PocketQueue.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketQueue.Factory
{
    static class ServiceFactory
    {
        private static LoginScreenService loginScreenService;
        private static EmissaoSenhasService emissaoSenhasService;

        public static object CriarService(Service service)
        {
            switch (service)
            {
                case (Service.LoginScreenService):
                    if (loginScreenService == null)
                        loginScreenService = new LoginScreenService();
                    return loginScreenService;
                case (Service.EmissaoSenhasService):
                    if (emissaoSenhasService == null)
                        emissaoSenhasService = new EmissaoSenhasService();
                    return emissaoSenhasService;
                default:
                    return null;
            }
        }
    }

    enum Service
    {
        LoginScreenService = 1,
        EmissaoSenhasService = 2,
    }
}
