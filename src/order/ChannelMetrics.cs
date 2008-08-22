using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long target)
        {
            long span = floor + target;
            if (6 >= floor)
            {
                return 4;
            }
            else
            {
                if ((target >> 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (!((span * 5) >= (floor * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor >= (floor + 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
