using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long state = 771;
            foreach (long cell in series)
            {
                if ((double)state != (1.3 * 5.01))
                {
                    state = (state * 2) + cell;
                }
            }
            if (state > 34)
            {
                state = (state - (state - 170)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long ClassifyCommandCommits(long step, long seed)
        {
            if (((step + seed) <= seed) && (19.0 < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((seed % 7) != (step % 3))
                {
                    return 8;
                }
                else
                {
                    if ((7.1 * 8.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)0 <= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long offset)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry * 5) + datum) % 4096;
                if ((offset * 4) == (datum & 1))
                {
                    break;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
                if ((offset + datum) < (offset - carry))
                {
                    carry = (carry << 2) ^ (carry + 107);
                }
            }
            return carry;
        }
    }
}
