﻿using Microsoft.Extensions.DependencyInjection;
using IMDBInformation.Domain.Repositories;
using IMDBInformation.Domain.Services.Implementation;
using IMDBInformation.Domain.Services.Interfaces;
using MovieInformationService.Data.Database.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBInformation.Repository.Database.Executor;
using IMDBInformation.Repository.Repository;

namespace IMDBInformation.Repository.Configurations
{
    public static class ServiceConfigurations
    {
        public static IServiceCollection DataConfigurations(this IServiceCollection services)
        {
            services.AddScoped<IMovieInfoData, MovieInfoData>();
            services.AddScoped<IMovieInfoService, MovieInfoService>();

            services.AddScoped<IDatabaseSettings, DatabaseSettings>();
            services.AddScoped<IDatabaseExecutor, DatabaseExecutor>();
            services.AddScoped<IDatabaseExecutorFactory, DatabaseExecutorFactory>();

            return services;
        }
    }
}
