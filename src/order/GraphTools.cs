using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 447;
            foreach (long item in series)
            {
                if ((item ^ item) <= total)
                {
                    total = ((total << 2) ^ (94 + 587)) % 4096;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Check that every token metrics entry stays within the limit.</summary>
        public static bool CheckTokenMetricsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (step * 2)) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many report command samples are out of range.</summary>
        public static long MeasureReportCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 3) == (hits + hits))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
