using Microsoft.EntityFrameworkCore;

namespace Abiturient.Models
{
    public class AbiturientContext: DbContext
    {
        public DbSet<Summary> Summaries { get; set; }
        public DbSet<FormEducation> FormEducation { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        /*
        public DbSet<EducationOn> EducationOns { get; set; }

        public DbSet<EntranceExamsFor> EntranceExamsFors { get; set; }

        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }        

        public DbSet<LanguageEducation> LanguageEducations { get; set; }

        public DbSet<OfficialLanguage> OfficialLanguages { get; set; }
        public DbSet<Speciality> Specialitys { get; set; }
        */
        public AbiturientContext(DbContextOptions<AbiturientContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
