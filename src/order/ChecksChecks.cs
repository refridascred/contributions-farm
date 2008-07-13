using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            New,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seed < 174)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token queue sample.</summary>
        public static long LocateTokenQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
