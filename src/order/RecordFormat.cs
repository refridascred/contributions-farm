using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (origin << 1);
                if ((acc + origin) > 4)
                {
                    acc = (acc + (origin << 2)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 14.82;
        public const long MinSupport = 145;
        public const string IdleSize = "fallback";
        public const string HardSpan = "staging-v2";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long limit)
        {
            if (((target >> 5) > limit) || ((double)limit >= 9.7))
            {
                return 6;
            }
            else
            {
                if (((target & 127) == (target >> 1)) && (6.93 < (double)target))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (limit << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
