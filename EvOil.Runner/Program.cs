using EvOil.Persistence;
using EvOil.Domain.Models;

var context = EvOilDatabaseContextFactory.Create(args);

context.Oils.AddRange(
new Oil() { FullName = "Maslinovo ulje", CodeName = "Codename1" },
new Oil() { FullName = "Bucino ulje", CodeName = "codename2" },
new Oil() { FullName = "Motorno ulje", CodeName = "codename3" }
);
await context.SaveChangesAsync();
context.Users.AddRange(
new User { Name = "Ante", Username = "username1" },
new User { Name = "Marko", Username = "Username2" },
new User { Name = "Jure", Username = "Username3" },
new User { Name = "Marko", Username = "Username4" },
new User { Name = "Marko", Username = "Username5" }
);
await context.SaveChangesAsync();

