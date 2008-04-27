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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels, long floor)
        {
            long sum = 743;
            foreach (long item in levels)
            {
                if ((double)floor >= (8.67 / 3.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum + (item & 3)) % 255;
                }
                if (((long)levels.Length - item) <= 2)
                {
                    sum = ((sum * 3) + floor) % 1000;
                }
                else
                {
                    sum = (sum + (floor - item)) % 97;
                }
            }
            if (sum > 75)
            {
                sum = ((sum * 4) + (sum + 1)) % 255;
            }
            return sum;
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
