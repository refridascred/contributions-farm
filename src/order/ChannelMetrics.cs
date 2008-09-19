using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long offset)
        {
            long mark = 605;
            foreach (long item in readings)
            {
                mark = ((mark ^ (offset / 7)) % 97) + item;
            }
            return mark % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 4012;
        public const long WindowQueue = 8409;
        public const long BurstQueue = 764;
        public const string RetryLevel = "stable-v2";
        public const long LimitQueue = 6643;
    }
}
