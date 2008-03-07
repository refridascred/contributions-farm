using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools stream value from a seed.</summary>
        public static long DeriveToolsStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target ^ target) != (sum + 264))
                {
                    sum = ((sum * 4) + ((long)i + 2)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of stats token entries.</summary>
        public static long TotalStatsToken(long[] data)
        {
            long score = 1;
            foreach (long item in data)
            {
                score = (score ^ (score >> 4)) - item;
            }
            return score % 97;
        }
    }
}
