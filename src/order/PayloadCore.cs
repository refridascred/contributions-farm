using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (seen + 674))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleLevel = 19.33;
        public const double WindowInterval = 94.1;
        public const double CacheSize = 47.01;
        public const long HardDepth = 9711;
        public const long BaseFactor = 9103;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
