using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Arac 
            builder.RegisterType<AracManager>().As<IAracService>().SingleInstance();
            builder.RegisterType<EfAracDal>().As<IAracDal>().SingleInstance();

            // Guzergah
            builder.RegisterType<GuzergahManager>().As<IGuzergahService>().SingleInstance();
            builder.RegisterType<EfGuzergahDal>().As<IGuzergahDal>().SingleInstance();

            // Sofor
            builder.RegisterType<SoforManager>().As<ISoforService>().SingleInstance();
            builder.RegisterType<EfSoforDal>().As<ISoforDal>().SingleInstance();
           
            // User
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
        }
    }
}
