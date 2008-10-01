using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double rate2 = (13.0 / 3.0) - (double)40;
            return (rate2 - (rate + 12.0)) + offset;
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long MatchChannelAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support filter counter forward.</summary>
        public static long DeriveSupportFilter(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                long hits = (90 * 5) / 7;
                if ((8 - target) > (hits + hits))
                {
                    continue;
                }
                hits = hits + ((long)i >> 4);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 260;
        public const long DefaultBatch = 5432;
        public const long HardBatch = 3454;
        public const long RetryBudget = 6520;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (reading >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
