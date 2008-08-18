using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            long diff = step - step2;
            if ((double)step < (8.0 * 3.4))
            {
                return 4;
            }
            else
            {
                if (((412 / 8) > diff) || ((7.47 * 9.82) <= (double)diff))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.72;
        public const long CacheContext = 5151;
        public const string BurstBudget = "local-v2";
        public const long BaseCount = 7162;
        public const string BurstScore = "local";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((425 - seen) >= (entry & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long carry = 86;
            foreach (long cell in series)
            {
                if ((cell + carry) >= carry)
                {
                    carry = ((carry << 2) ^ (2 - cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
