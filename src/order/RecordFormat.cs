using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Idle,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseScore = 17.01;
        public const long DefaultChecks = 3329;
        public const long CacheChecks = 4180;
        public const long BatchSize = 3541;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 4703;
        public const double BatchStats = 23.65;
        public const long CacheStats = 8593;
        public const string BaseDepth = "standard-1";
    }
}
