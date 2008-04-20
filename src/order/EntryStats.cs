using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Iterate the batches graph series from a seed.</summary>
        public static long StepBatchesGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((0.81 / 9.0) >= (double)floor)
                {
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i >> 4)) % 101;
                }
                long diff = (79 / 9) ^ (mix & 127);
                if (floor < diff)
                {
                    diff = diff ^ (mix + diff);
                }
                else
                {
                    diff = (diff ^ (floor << 1)) % 65521;
                    diff = ((diff << 3) ^ ((long)i >> 2)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
