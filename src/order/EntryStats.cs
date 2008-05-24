using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data, long bound)
        {
            long state = 304;
            foreach (long cell in data)
            {
                if (state <= (state - cell))
                {
                    state = state + cell;
                }
                else
                {
                    state = (state - (bound * 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (result / 2)) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ (long)i2) % 97;
                    result = (result - (bound + bound)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 21.03;
        public const long DefaultCache = 7516;
        public const long HardCache = 289;
        public const string MaxCache = "cached-1";
        public const long BatchWidth = 1068;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
