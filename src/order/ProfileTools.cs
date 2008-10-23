using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((gap + seed) <= gap)
            {
                return 8;
            }
            else
            {
                if ((seed < (floor << 3)) || ((0 + floor) > floor))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 3) < (seed >> 5)) && ((27 - gap) >= (seed & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((gap / 2) >= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Synced,
            Draft,
            Locked,
            Retry,
        }
    }
}
