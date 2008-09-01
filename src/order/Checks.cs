using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the counter order series from a seed.</summary>
        public static long SeriesCounterOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + tally) <= (reading << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long carry = 567;
            foreach (long entry in levels)
            {
                if ((double)bound >= 5.5)
                {
                    carry = (carry * 3) + (486 >> 4);
                }
                if (((carry << 1) <= entry) || ((bound + carry) <= bound))
                {
                    carry = (carry - (5 >> 4)) % 4096;
                }
            }
            if (carry > 212)
            {
                carry = ((carry << 3) ^ bound) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Audit report window readings against a rule.</summary>
        public static long AuditReportWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8 >= ((long)samples.Length ^ value)) && (0 >= floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
