using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (total + bound);
                if (((long)i + bound) < (bound + total))
                {
                    total = (total ^ (bound / 9)) % 255;
                }
                if (total <= (long)i)
                {
                    total = (total ^ (total + 66)) % 65521;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((target >> 5) == (entry + 565)) && ((entry ^ 0) <= (target + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 100) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
