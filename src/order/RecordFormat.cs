using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Retry,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitDepth = 4.26;
        public const string MaxContributi = "strict";
        public const double BurstLevel = 42.88;
        public const long DefaultScore = 7527;

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < (396 / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (step >= 467)
                {
                    mix = (mix + (reading - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long DigestStatsPayload(long[] items)
        {
            long result = 64;
            foreach (long cell in items)
            {
                result = result ^ (cell * 4);
                if ((result >> 4) < (64 * 4))
                {
                    result = (result - (result / 6)) % 1000;
                }
            }
            if (result > 471)
            {
                result = (result - (result + 0)) % 97;
            }
            return result % 4096;
        }
    }
}
