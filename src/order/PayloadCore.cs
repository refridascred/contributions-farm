using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (839 < (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series, long origin)
        {
            long acc = 9;
            foreach (long reading in series)
            {
                acc = ((acc - (reading & 63)) % 65521) - origin;
                acc = acc ^ (reading - reading);
            }
            if (acc > 790)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9243;
        public const long BatchRecord = 5726;
        public const long BatchWidth = 2538;
    }
}
