using CrashReport.Domain.Abstract;
using CrashReport.Domain.Concrete;
using Ninject;
using System;
using System.Web.Mvc;

namespace CrashReport.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }

        private void AddBindings()
        {
            kernel.Bind<IReportRepository>().To<DummyReportRepository>();
        }
    }
}