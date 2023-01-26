builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSignalR();
builder.Services.AddHostedService<HostedServicesClass>(); //agregamos la inyection de dependecy del hostedService
var app = builder.Build();
app.MapHub<ChatHub>("/SignalR");  //agregamos la clase Hub
