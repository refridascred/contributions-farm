using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (seed << 3)) % 97;
                carry = (carry - (carry + 1)) % 1000;
                if ((carry + 773) > (seed >> 5))
                {
                    carry = (carry << 3) ^ seed;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            if (target < (origin << 3))
            {
                return 6;
            }
            else
            {
                if ((21 ^ 34) == (target << 1))
                {
                    return 3;
                }
                else
                {
                    if (36 >= (target * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.96 * 7.91) == (double)target) && ((double)origin != (12.0 / 2.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
