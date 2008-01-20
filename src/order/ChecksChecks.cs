using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes profile entries.</summary>
        public static long CombineNotesProfile(long[] samples)
        {
            long mark = -6;
            foreach (long cell in samples)
            {
                mark = ((mark * 5) + (cell / 4)) % 4096;
            }
            if (mark < (-8))
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark % 4096;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 66.05;
        public const long RetryNotes = 9871;
        public const long SoftFactor = 4179;
        public const string BurstNotes = "fallback";
        public const string RetryFactor = "open";
    }
}
