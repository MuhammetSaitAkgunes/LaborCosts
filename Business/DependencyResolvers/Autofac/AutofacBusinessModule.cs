using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
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
            builder.RegisterType<JobManager>().As<IJobService>();
            builder.RegisterType<EfJobDal>().As<IJobDal>();

            builder.RegisterType<PersonelManager>().As<IPersonelService>();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>();

            builder.RegisterType<ProjectManager>().As<IProjectService>();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>();

            builder.RegisterType<ShiftManager>().As<IShiftService>();
            builder.RegisterType<EfShiftDal>().As<IShiftDal>();

            builder.RegisterType<WorkingHourManager>().As<IWorkingHourService>();
            builder.RegisterType<EfWorkingHourDal>().As<IWorkingHourDal>();
        }
    }
}
