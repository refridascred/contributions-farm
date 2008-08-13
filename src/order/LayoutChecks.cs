using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally > (2.0 / 5.0))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 10.49;
        public const string WindowRatio = "alpha";
        public const long BurstEditor = 9370;
        public const long StepEditor = 7159;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record session readings against a rule.</summary>
        public static long AuditRecordSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) > tally) && ((datum + datum) != (tally ^ tally))) && (datum < (datum * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
