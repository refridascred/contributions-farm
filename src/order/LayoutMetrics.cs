using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen << 3) != (sample ^ seen))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double drift = gain;
            return (drift - gain) + bias;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)target < (double)target) && (sample <= (sample * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
