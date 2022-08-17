using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public enum TeacherRank { Assistant, Associate, Full, Professor }
        public TeacherRank Rank { get; set; }
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
