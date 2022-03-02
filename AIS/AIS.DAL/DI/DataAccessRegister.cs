﻿using AIS.DAL.Entities;
using AIS.DAL.Interfaces.Repositories;
using AIS.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AIS.DAL.DI
{
    public static class DataAccessRegister
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IGenericRepository<IntervieweeEntity>, IntervieweeRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();
            services.AddScoped<IGenericRepository<EmployeeEntity>, EmployeeRepository>();
            services.AddScoped<IGenericRepository<CompanyEntity>, CompanyRepository>();
            services.AddScoped<IGenericRepository<QuestionIntervieweeAnswerEntity>, QuestionIntervieweeAnswerRepository>();
            services.AddScoped<IGenericRepository<QuestionEntity>, QuestionRepository>();
            services.AddScoped<IGenericRepository<QuestionAreaEntity>, QuestionAreaRepository>();
            services.AddScoped<IGenericRepository<QuestionSetEntity>, QuestionSetRepository>();
            services.AddScoped<IGenericRepository<TrueAnswerEntity>, TrueAnswerRepository>();
            services.AddScoped<IGenericRepository<QuestionsQuestionSetsEntity>, QuestionsQuestionSetsRepository>();
            services.AddScoped<IGenericRepository<QuestionsQuestionSetsEntity>, QuestionsQuestionSetsRepository>();
            services.AddDbContext<DatabaseContext>(op =>
                {
                    op.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                }
            );
        }
    }
}