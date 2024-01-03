using Autofac;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IRoomService>().As<IRoomService>().SingleInstance();
            builder.RegisterType<EfRoomDal>().As<IRoomService>().SingleInstance();

            builder.RegisterType<IServiceService>().As<IServiceService>().SingleInstance();
            builder.RegisterType<EfServiceDal>().As<IServiceService>().SingleInstance();

            builder.RegisterType<IStaffService>().As<IStaffService>().SingleInstance();
            builder.RegisterType<EfStaffDal>().As<IStaffService>().SingleInstance(); 

            builder.RegisterType<ISubscribeService>().As<ISubscribeService>().SingleInstance();
            builder.RegisterType<EfSubscribeDal>().As<ISubscribeService>().SingleInstance(); 

            builder.RegisterType<ITestimonialService>().As<ITestimonialService>().SingleInstance();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialService>().SingleInstance();

            //buradan sonra program.cs ekleme yapıldı
        }
    }
}
