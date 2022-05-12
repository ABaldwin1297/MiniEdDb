using Microsoft.EntityFrameworkCore;
using MiniEdDb.Models;

void Main() { };

var db = new AppDbContext();

db.Majors.ToList().ForEach(x => Console.WriteLine(x));

db.Students.Include(x => x.Major).ToList().ForEach(x => Console.WriteLine(x));

