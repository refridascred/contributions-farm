using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank payload queue input into a small class.</summary>
        public static long BucketPayloadQueue(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge >> 4) <= (edge ^ floor))
            {
                return 4;
            }
            else
            {
                if ((floor2 / 5) != (floor2 + floor2))
                {
                    return 1;
                }
                else
                {
                    if (edge <= (floor2 + floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count order session pairs that satisfy a relation.</summary>
        public static long MatchOrderSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double drift = (double)537 + (4.0 - offset);
            if (drift >= gain)
            {
                drift = drift - (8.5 - 1.4);
            }
            else
            {
                drift = drift + (double)113;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain * 6.0);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
