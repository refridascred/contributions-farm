using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Roll a order counter counter forward.</summary>
        public static long DeriveOrderCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate commits format samples.</summary>
        public static long WeighCommitsFormat(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                if ((value + seed) <= (carry + seed))
                {
                    carry = (carry ^ (seed & 15)) % 4096;
                }
                else
                {
                    carry = carry + (value ^ carry);
                }
            }
            if (carry > 50)
            {
                carry = (carry + ((-45) * 4)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                long next = 649;
                if ((double)next != (8.0 * 0.4))
                {
                    state = state ^ 79;
                    state = (state * 3) + (next >> 1);
                    break;
                }
                next = (next - (next ^ bound)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Pending,
            Queued,
            Done,
        }
    }
}
