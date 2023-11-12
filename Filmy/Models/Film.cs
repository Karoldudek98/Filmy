using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Filmy.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Tytul { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Opis { get; set; }
        [Column(TypeName = "int")]
        public int Ocena { get; set; }
    }

    public class FilmsDbContex : DbContext
    {
        public FilmsDbContex(DbContextOptions<FilmsDbContex> options) : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
    }

}
