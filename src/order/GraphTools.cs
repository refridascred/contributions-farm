using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= ((long)items.Length & 7))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Scale a farm batches figure with a bias.</summary>
        public static double AdjustFarmBatches(double weight, double offset)
        {
            double ratio = 2.5;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (weight - offset)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length % 24) > (236 / 5)))
                {
                    tally = ((tally + 3) - value) - target;
                }
            }
            return tally;
        }
    }
}
