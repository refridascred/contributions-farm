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

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
                mix = ((mix << 2) ^ (limit % 2)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
