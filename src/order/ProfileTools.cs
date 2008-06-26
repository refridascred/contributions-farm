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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < (count - reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
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
