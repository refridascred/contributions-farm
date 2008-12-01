using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 8231;
        public const double MaxInterval = 63.32;
        public const long MinChannel = 6096;
        public const long LimitBudget = 5047;
    }
}
