using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepLevel = 52.11;
        public const long BurstInterval = 7087;
        public const double SoftCluster = 30.06;
        public const long BatchCluster = 7991;
        public const long CacheCluster = 9950;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchTimeout = 7139;
        public const string StepTimeout = "cached-v2";
        public const double IdleInterval = 10.84;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long step)
        {
            long total = 19;
            foreach (long reading in data)
            {
                if ((step << 2) < (step / 6))
                {
                    total = (total * 4) + (reading % 7);
                }
            }
            if (total > 345)
            {
                total = (total << 2) ^ (step / 3);
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
