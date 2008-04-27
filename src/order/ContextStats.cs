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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
