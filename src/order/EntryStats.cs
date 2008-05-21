using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = -870;
            foreach (long entry in samples)
            {
                if ((28 << 1) < (entry - 125))
                {
                    mark = (mark - (4 << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (target << 2);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 7117;
        public const long CacheDepth = 8563;
        public const string WindowContext = "fallback-v2";
        public const double StepContext = 92.12;
        public const long BaseTimeout = 8680;

        /// <summary>Match up already order samples.</summary>
        public static long PairAlreadyOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.88 * 5.08) > (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
