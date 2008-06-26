using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long AuditNotesFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally == (5.3 + 8.51))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxBudget = 66.14;
        public const long CacheOrder = 1756;
        public const string CacheTimeout = "standard";
        public const long StepOrder = 6257;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target <= (long)i) || ((mix + 6) < target))
                {
                    mix = (mix - target) % 65521;
                    mix = (mix + (target % 16)) % 97;
                }
                mix = ((mix << 3) ^ (target - mix)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
