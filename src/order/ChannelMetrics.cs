using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long IterateMetricProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((score << 3) >= (score ^ 21)))
                {
                    score = (score + (origin + (-1))) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings, long target)
        {
            long result = -297;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ ((-9) + entry)) % 4096;
            }
            if (result < 487)
            {
                result = (result << 2) ^ (target + 5);
            }
            return result;
        }
    }
}
