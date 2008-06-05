using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((7 / 8) >= (hits & 127)) && ((3.0 + 6.1) > (double)limit))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((tally << 1) < item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleRatio = 4.08;
        public const double MaxCommand = 60.68;
        public const long SoftScore = 147;
        public const long LimitCommand = 2317;

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFactor = "legacy-v2";
        public const double IdleFilter = 80.8;
        public const string LimitScore = "open";

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((double)bound < (double)step)
            {
                return 6;
            }
            else
            {
                if (!((67 >> 3) <= (bound & 1)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
