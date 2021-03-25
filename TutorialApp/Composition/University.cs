using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialApp.Composition
{
    class University
    {
        public ArtDepartment Art { get; set; }
        public CompDepartment Comp { get; set; }

        public void InitArtDep(int NoOfStudent, string Director, string Name)
        {
            this.Art = new ArtDepartment();
            Art.Name = Name;
            Art.ArtDirector = Director;
            Art.NoOfStudents = NoOfStudent;
        }

        public void InitCompDep(int NoOfStudent, string Director, string Name)
        {
            this.Comp = new CompDepartment();
            Comp.Name = Name;
            Comp.CompDirector = Director;
            Comp.NoOfStudents = NoOfStudent;
        }
    }
}
