using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ ((-2) << 3);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 38.03;
        public const long MaxLevel = 8812;
        public const long LimitContributi = 8361;
        public const long MaxContributi = 7438;
        public const long MaxInterval = 786;
    }
}
