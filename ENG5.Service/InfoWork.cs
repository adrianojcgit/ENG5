using ENG5.Application.DTOs;
using ENG5.Application.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ENG5.Service
{
    public class InfoWork : IHostedService
    {
        private readonly ICategoryService _categoryService;
        public InfoWork(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        Task IHostedService.StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Serviço {nameof(InfoWork)} inicializando...");
            //var cat = GetCategotias();
            return Task.CompletedTask;
        }

        Task IHostedService.StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Serviço {nameof(InfoWork)} finalizado.");
            return Task.CompletedTask;
        }

        //private async Task<IEnumerable<CategoryDTO>> GetCategotias()
        //{
        //    var categories = await _categoryService.GetCategories();
        //    return categories;
        //}
    }
}
