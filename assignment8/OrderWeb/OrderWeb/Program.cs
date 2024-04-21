
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using OrderWeb.Models;

namespace order_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //��DbContext���뵽����
            builder.Services.AddDbContext<OrderContext>(opt => opt.UseMySQL(
                "Server=localhost;Database=orderDB;User=root;Password=root"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDefaultFiles(); //����ȱʡ��̬ҳ�棨index.html��index.htm��
            app.UseStaticFiles(); //���þ�̬�ļ���ҳ�桢js��ͼƬ�ȸ���ǰ���ļ���

            app.UseHttpsRedirection(); //����http��https���ض���
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}