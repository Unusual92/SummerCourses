                    using _5_lesson.Interfaces;
                    using _5_lesson.Services;

                    var builder = WebApplication.CreateBuilder(args);

                    builder.Services.AddCors();

                    builder.Services.AddControllers();
                    builder.Services.AddEndpointsApiExplorer();
                    builder.Services.AddSwaggerGen();
                    builder.Services.AddSingleton<IPostsRepository, PostsRepository>();
                    builder.Services.AddHttpLogging(o => { });

                    builder.Services.AddCors(options =>
                    {
                        options.AddPolicy("AllowAll",
                            builder => builder.AllowAnyOrigin()
                                .AllowAnyHeader()       
                                .AllowAnyMethod());
                    });

                    var app = builder.Build();

                    app.UseHttpLogging();

                    app.UseCors("AllowAll");

                    if (app.Environment.IsDevelopment())
                    {
                        app.UseSwagger();
                        app.UseSwaggerUI();
                    }

                    app.UseHttpsRedirection();

                    app.MapControllers();

                    app.Run();