using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 357;
            foreach (long reading in series)
            {
                mark = (mark << 2) ^ (reading + reading);
            }
            if (mark < 66)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark;
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
