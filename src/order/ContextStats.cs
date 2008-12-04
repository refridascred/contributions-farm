using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6834;
        public const long HardSize = 9547;
        public const long StepContributi = 7154;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                mix = mix + (entry + entry);
            }
            if (mix < 75)
            {
                mix = mix - (mix ^ (-62));
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Stale,
            Done,
            Draft,
        }
    }
}
