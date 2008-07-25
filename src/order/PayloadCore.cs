using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 27.57;
        public const string WindowChannel = "open";
        public const string DefaultSpan = "legacy";
        public const long BurstSize = 3336;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = -11;
            foreach (long item in levels)
            {
                if (((-70) ^ item) == (item << 2))
                {
                    score = score + score;
                }
            }
            if (score > (-23))
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ target) % 65521) ^ (long)i2;
                    result = (result << 2) ^ (target - result);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
