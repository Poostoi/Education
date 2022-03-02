using System;
using System.Collections.Generic;
using System.Linq;
using Abiturient.Models;
using System.Threading.Tasks;

namespace Abiturient
{
    public class SampleData
    {
        public static void Initialize(AbiturientContext context)
        {
            if (!context.Summaries.Any())
            {
                context.Summaries.AddRange(
                    
                    new Summary
                    {
                        EducationOn = new EducationOn
                        { Content = "Бюджет" },
                        EntranceExamsFor = new EntranceExamsFor
                        { Content = "Русский" },
                        Faculty = new Faculty
                        { Content = "ФМФ" },
                        ForeignLanguage = new ForeignLanguage
                        { Content = "Английский" },
                        FormEducation = new FormEducation
                        { Content = "Дневная" },
                        LanguageEducation = new LanguageEducation
                        { Content = "Русский" },
                        OfficialLanguage = new OfficialLanguage
                        { Content = "Молдавский" },
                        Speciality = new Speciality
                        { Content = "Программист" }
                    },
                    new Summary
                    {
                        EducationOn = new EducationOn
                        { Content = "Контракт" },
                        EntranceExamsFor = new EntranceExamsFor
                        { Content = "Русский" },
                        Faculty = new Faculty
                        { Content = "ЕГФ" },
                        ForeignLanguage = new ForeignLanguage
                        { Content = "Английский" },
                        FormEducation = new FormEducation
                        { Content = "Заочная" },
                        LanguageEducation = new LanguageEducation
                        { Content = "Русский" },
                        OfficialLanguage = new OfficialLanguage
                        { Content = "Молдавский" },
                        Speciality = new Speciality
                        { Content = "Турист" }
                    },
                    new Summary
                    {
                        EducationOn = new EducationOn
                        { Content = "Контракт" },
                        EntranceExamsFor = new EntranceExamsFor
                        { Content = "Русский" },
                        Faculty = new Faculty
                        { Content = "ФФ" },
                        ForeignLanguage = new ForeignLanguage
                        { Content = "Английский" },
                        FormEducation = new FormEducation
                        { Content = "Заочная" },
                        LanguageEducation = new LanguageEducation
                        { Content = "Русский" },
                        OfficialLanguage = new OfficialLanguage
                        { Content = "Молдавский" },
                        Speciality = new Speciality
                        { Content = "Лингвист" }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
