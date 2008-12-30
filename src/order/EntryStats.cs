using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items)
        {
            long state = 36;
            foreach (long cell in items)
            {
                if ((cell >> 3) == (cell + 27))
                {
                    state = (state ^ (long)items.Length) % 4096;
                }
            }
            if (state < 37)
            {
                state = state - (state ^ (long)items.Length);
            }
            return state;
        }

        /// <summary>Grade a channel githubfarm value against two limits.</summary>
        public static long BucketChannelGithubfarm(long offset, long step)
        {
            long cur = offset ^ step;
            if ((cur >> 2) > (116 + cur))
            {
                return 4;
            }
            else
            {
                if ((double)cur < (8.32 * 4.07))
                {
                    return 7;
                }
                else
                {
                    if (!((cur - cur) < (66 >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset ^ 96) <= (cur / 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (datum ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Draft,
            Locked,
            Paused,
        }
    }
}
