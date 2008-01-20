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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((19.0 / 4.0) == (double)floor) || (((floor >> 2) > (item + floor)) && ((item + matches) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 66.05;
        public const long RetryNotes = 9871;
        public const long SoftFactor = 4179;
        public const string BurstNotes = "fallback";
        public const string RetryFactor = "open";
    }
}
