using System.ComponentModel;

namespace StudentEnrollment.Enum
{
    public enum Semester
    {
        Fall=1,
        Spring=2,
        Summer=3,
    }

    public enum LetterGrade
    {
        [Description("A+")]
        A_Plus,
        [Description("A")]
        A,
        [Description("A-")]
        A_Minus,
        [Description("B+")]
        B_Plus,
        [Description("B")]
        B,
        [Description("B-")]
        B_Minus,
        [Description("C+")]
        C_Plus,
        [Description("C-")]
        C,
        [Description("C-")]
        C_Minus,
        [Description("D+")]
        D_Plus,
        [Description("D")]
        D,
        [Description("D-")]
        D_Minus,
        [Description("F")]
        F,
        W
    }



}