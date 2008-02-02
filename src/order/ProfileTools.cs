using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)(long)i <= 4.2))
                {
                    break;
                }
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank schema contributi input into a small class.</summary>
        public static long RankSchemaContributi(long target, long seed)
        {
            long step = target + seed;
            if ((step ^ step) >= (8 & 255))
            {
                return 7;
            }
            else
            {
                if (((step - seed) >= (step % 100)) && ((double)target > (double)384))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
