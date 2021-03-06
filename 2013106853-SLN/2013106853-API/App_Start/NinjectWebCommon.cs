[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2013106853_API.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(_2013106853_API.App_Start.NinjectWebCommon), "Stop")]

namespace _2013106853_API.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using _2013106853_ENT.IRepositories;
    using _2013106853_PER;
    using _2013106853_PER.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using WebApiContrib.IoC.Ninject;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                //soporte para web API
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //UnityOfWork
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();


            kernel.Bind<_2013106853DbContext>().To<_2013106853DbContext>();

            //AsientoRepository
            kernel.Bind<IAsientoRepository>().To<IAsientoRepository>();

            //LlantaRepository
            kernel.Bind<ILlantaRepository>().To<ILlantaRepository>();

            //ParabrisasRepository
            kernel.Bind<IParabrisasRepository>().To<IParabrisasRepository>();

            //PropietarioRepository
            kernel.Bind<IPropietarioRepository>().To<IPropietarioRepository>();
        }        
    }
}
