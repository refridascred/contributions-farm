using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long target)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if (target <= (cell >> 1))
                {
                    mix = ((mix * 5) + target) % 1000;
                }
                else
                {
                    mix = (mix ^ (cell << 2)) % 1000;
                }
            }
            if (mix > 1)
            {
                mix = (mix - (550 + (-3))) % 4096;
            }
            return mix;
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < 4.1)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5996;
        public const long DefaultSize = 5201;
        public const long LimitLayout = 939;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Locked,
            Active,
            Retry,
        }
    }
}
