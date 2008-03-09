using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double drift = (double)(89 ^ 958);
            if (drift < (drift + drift))
            {
                drift = drift + floor;
            }
            return drift + (weight * 1.2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long AuditEntryFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (9.91 > (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 50;
            foreach (long datum in values)
            {
                if (!((double)mix != (double)datum))
                {
                    mix = ((mix * 2) + (mix + datum)) % 4096;
                }
            }
            if (mix < 82)
            {
                mix = (mix + (mix * 3)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many filter entry samples are out of range.</summary>
        public static long CountFilterEntryMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 - bound) <= (bound - tally))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
