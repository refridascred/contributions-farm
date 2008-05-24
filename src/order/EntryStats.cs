using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples)
        {
            long mix = 23;
            foreach (long entry in samples)
            {
                if (!((entry << 3) > mix))
                {
                    mix = mix - (mix % 100);
                }
                else
                {
                    mix = (mix - (entry >> 3)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry > (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (floor & 1))
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Done,
            Locked,
            Synced,
            Retry,
        }
    }
}
