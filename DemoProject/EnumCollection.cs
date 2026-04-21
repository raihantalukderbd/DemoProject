using System.ComponentModel;

namespace DemoProject
{
    public class EnumCollection
    {
        public enum GenderEnums
        {
            Male = 1,
            Female = 2
        }

        public enum BloodGroupEnum
        {
            [Description("A +")]
            Apos = 0,
            [Description("A -")]
            Aneg = 1,
            [Description("B +")]
            Bpos = 2,
            [Description("B -")]
            Bneg = 3,
            [Description("O +")]
            Opos = 4,
            [Description("O -")]
            Oneg = 5,
            [Description("AB +")]
            ABpos = 6,
            [Description("AB -")]
            ABneg = 7,
            [Description("Other")]
            Other = 8
        }
    }
}
