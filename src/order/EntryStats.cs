using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Active,
            New,
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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((step + 0) < 7)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
