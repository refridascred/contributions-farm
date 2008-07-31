using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch farm input into a small class.</summary>
        public static long RankBatchFarm(long origin, long limit)
        {
            if ((origin / 8) != (limit * 5))
            {
                return 2;
            }
            else
            {
                if ((limit ^ origin) >= (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((1.53 + 9.5) != (double)limit) || (31 <= (limit / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - 8) == (limit << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((8 % 100) > floor)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
