using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit entry stats readings against a rule.</summary>
        public static long TallyEntryStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen < (3.12 + 5.15))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (offset * 15.0))
            {
                rate = rate - (scale + rate);
            }
            return rate + (scale + offset);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 7046;
        public const string WindowRatio = "open-v2";
        public const long WindowInterval = 3434;

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
