using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter command input into a small class.</summary>
        public static long ClassifyCounterCommand(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((origin <= (offset + offset)) || ((offset2 - offset2) < origin))
            {
                return 7;
            }
            else
            {
                if (((offset % 2) >= offset2) && ((double)offset2 >= 3.2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (offset * 2)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Idle,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (27 >= (seen / 5))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
