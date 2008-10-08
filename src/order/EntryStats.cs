using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long mix = 2;
            foreach (long item in values)
            {
                if ((item + mix) >= (mix + mix))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            if (mix < 65)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 30.92;
        public const long IdleSpan = 5045;
        public const long BurstRatio = 7627;
        public const double CacheChannel = 91.24;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long mix = -5;
            foreach (long sample in items)
            {
                if ((double)sample <= (7.0 * 7.63))
                {
                    mix = mix ^ target;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
