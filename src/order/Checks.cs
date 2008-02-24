using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (273 > (seed ^ carry))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)origin >= (5.9 / 6.0)) && !(((long)series.Length * 2) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long limit)
        {
            if ((double)limit >= (5.05 - 1.5))
            {
                return 7;
            }
            else
            {
                if ((8.0 / 3.0) >= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
