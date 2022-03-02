using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abiturient.Models
{
    public class Summary
    {
        public int Id { get; set; }
        public int EducationOnId { get; set; }
        public EducationOn EducationOn { get; set; }
        public int EntranceExamsForId { get; set; }
        public EntranceExamsFor EntranceExamsFor { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public int ForeignLanguageId { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }
        public int FormEducationId { get; set; }
        public FormEducation FormEducation { get; set; }
        public int LanguageEducationId { get; set; }
        public LanguageEducation LanguageEducation { get; set; }
        public int OfficialLanguageId { get; set; }
        public OfficialLanguage OfficialLanguage { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
}
