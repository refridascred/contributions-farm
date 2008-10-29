using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank token graph input into a small class.</summary>
        public static long BucketTokenGraph(long origin, long origin2)
        {
            if (origin2 > (origin2 % 24))
            {
                return 8;
            }
            else
            {
                if (((double)origin2 >= (double)9) || ((double)origin < (3.0 + 4.8)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item & 63) == (12 % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long step)
        {
            long edge = bound ^ step;
            if (((step ^ 24) != (bound & 1)) && ((241 % 64) > (bound - 385)))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > 612)
                {
                    return 7;
                }
                else
                {
                    if (!((edge % 60) == (step / 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
