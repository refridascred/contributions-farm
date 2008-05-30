using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryBudget = "strict";
        public const string StepInterval = "strict-edge";
        public const double SoftSize = 60.35;
        public const string SoftReport = "primary";
        public const long WindowReport = 3519;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length < (13.0 * 13.0))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the record stats entries that pass the check.</summary>
        public static long CountRecordStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading <= seen) || ((2.0 / 5.0) == (double)seen)) && ((seen & 7) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next record buffer value.</summary>
        public static double BlendRecordBuffer(double ratio, double offset)
        {
            double scale = (double)(8 * 3);
            if (scale > ratio)
            {
                scale = (scale + (ratio / 8.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (6.16 * 4.56)) - (double)(long)i;
            }
            return scale - (2.5 - ratio);
        }
    }
}
