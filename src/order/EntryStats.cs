using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2183;
        public const long LimitFactor = 5020;
        public const long DefaultSize = 9077;
        public const double HardChecks = 30.44;
        public const long DefaultChecks = 8513;
    }
}
