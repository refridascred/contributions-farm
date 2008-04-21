using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items)
        {
            long state = 854;
            foreach (long entry in items)
            {
                state = state ^ (entry >> 2);
                state = (state - (entry & 1)) % 255;
                if ((state + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7217;
        public const string MaxCache = "latest";
        public const string BatchWidth = "primary-edge";
        public const long BurstInterval = 4988;
        public const long DefaultCache = 6356;
    }
}
