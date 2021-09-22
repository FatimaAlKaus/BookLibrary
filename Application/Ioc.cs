using Application.Interfaces;
using Application.Services;
using Application.ViewModels;
using Domain.Repository;
using Infrastructure.EF;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace Application
{
    public static class Ioc
    {
        private static readonly IServiceProvider provider;
        public static T Resolve<T>() => provider.GetRequiredService<T>();
        static Ioc()
        {
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            });
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddSingleton<MainViewModel>();

            provider = services.BuildServiceProvider();
        }
    }
}
