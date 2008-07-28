using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many context checks samples are out of range.</summary>
        public static long MeasureContextChecksMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (origin <= (reading + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel cache sample.</summary>
        public static long LocateChannelCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryScore = 9031;
        public const long RetryContributi = 4430;
        public const long MinContributi = 2777;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleScore = 5685;
        public const string BatchFarm = "fallback";
        public const long HardRatio = 760;
        public const long MinTimeout = 4015;
        public const long CacheFarm = 9233;
    }
}
