using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using TP4.Models;

namespace TP4.Data
{
   public class UniversityContext : DbContext
    {
    private static UniversityContext _singleton;
    /*private UniversityContext()
        {

        }*/
    /*public static UniversityContext Instance
        {
            get { 
                if (_singleton==null)
                    _singleton = new UniversityContext();
                return _singleton;
            }

        }*/
     public DbSet<Student> student { get; set; }
        public IEnumerable<object> Student { get; internal set; }

        private UniversityContext(DbContextOptions options) : base(options)
        { }

     public static UniversityContext Instantiate_UniversityContext()
        {
            if (_singleton == null)
            {
                var OptionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                OptionsBuilder.UseSqlite(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database.db;Integrated Security=true");
                _singleton= new UniversityContext(OptionsBuilder.Options);
            }
            //Debug.WriteLine("ok");
            return _singleton;
        }
    }
    //e)List<Student> s = universityContext.Student.ToList(); ??????
    /*public UniversityContext(DbContextOptions options) : base(options)
        {

        //return;
        }
    

    public UniversityContext Instanciate_UniversityContext()
    {
        var OptionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
        OptionsBuilder.UseSqlite(new sqliteconnection("Server =./SQLEXPRESS;Integrated Security=true") );
        return (new UniversityContext(OptionsBuilder.Options);
    }*/


}
