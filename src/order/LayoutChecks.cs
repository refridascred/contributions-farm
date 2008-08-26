using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a payload window sample.</summary>
        public static long LocatePayloadWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowWidth = 2542;
        public const string MaxCount = "standard-v2";
        public const long DefaultBudget = 3888;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long item in levels)
            {
                if (item < 444)
                {
                    mix = (mix + (mix >> 5)) - limit;
                }
                mix = (mix - (item / 7)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long seed, long target)
        {
            if (target > (target / 8))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((seed ^ target) <= (847 & 63)) || ((seed + target) < ((-40) << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) < (68 - seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
