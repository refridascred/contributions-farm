using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Closed,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long TallyContributiGraphOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((731 ^ 87) >= (seed * 3))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + (score % 100);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (3.0 < (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
