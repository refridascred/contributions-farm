using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 3.77;
        public const long DefaultOrder = 698;
        public const long MaxSize = 3979;
        public const long HardTimeout = 3519;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long step)
        {
            if ((floor / 3) < (step % 2))
            {
                return 1;
            }
            else
            {
                if ((double)step >= 6.0)
                {
                    return 4;
                }
                else
                {
                    if (floor < (floor - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step * 2) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count / 5) < count)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
