using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long limit)
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

        /// <summary>Look up the position of a schema channel sample.</summary>
        public static long LookupSchemaChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSpan = 3796;
        public const long SoftProfile = 2747;
        public const string BaseSize = "local-1";
        public const long BurstTimeout = 8553;

        /// <summary>Rank window token input into a small class.</summary>
        public static long ClassifyWindowToken(long seed, long floor)
        {
            long slot = seed - floor;
            if (!((slot - seed) >= (floor * 3)))
            {
                return 1;
            }
            else
            {
                if ((845 >> 4) < (seed & 7))
                {
                    return 3;
                }
                else
                {
                    if ((7.6 - 3.27) >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed % 97) > floor) || (slot <= (floor ^ 949)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
