using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "standard";
        public const double CacheProfile = 19.44;
        public const long SoftProfile = 7304;
        public const long SoftRatio = 4247;
        public const long CacheCount = 5762;

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 47.76;
        public const long LimitTimeout = 219;
        public const string IdleFactor = "latest";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Queued,
            Paused,
        }
    }
}
