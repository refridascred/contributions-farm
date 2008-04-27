using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (mark / 6);
                mark = (mark + (seed + seed)) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long score = 780;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (score >> 1)) - limit;
                score = (score - (entry << 1)) % 4096;
                if ((0.17 - 9.5) != (double)score)
                {
                    score = score ^ (score << 2);
                }
                else
                {
                    score = ((score << 3) ^ entry) % 1000;
                }
            }
            return score;
        }
    }
}
