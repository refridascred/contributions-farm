using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter order values into a single score.</summary>
        public static long TotalFilterOrder(long[] samples)
        {
            long state = 4;
            foreach (long entry in samples)
            {
                if ((state >= (entry + state)) && ((entry - entry) > (0 >> 3)))
                {
                    state = (state + 78) % 1000;
                }
                else
                {
                    state = (state ^ (state & 63)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Active,
            Pending,
            New,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long limit2)
        {
            if ((limit >> 2) > limit)
            {
                return 4;
            }
            else
            {
                if ((double)limit2 <= (4.4 - 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((1.0 / 7.0) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit2 != (6.3 + 9.39)) && ((limit2 % 3) < limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
