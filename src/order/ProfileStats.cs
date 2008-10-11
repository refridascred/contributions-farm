using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session already readings.</summary>
        public static long WeighSessionAlready(long[] samples)
        {
            long total = 395;
            foreach (long sample in samples)
            {
                total = (total - (616 - sample)) % 65521;
                if ((double)sample >= (4.0 * 5.32))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile stream input into a small class.</summary>
        public static long GradeProfileStream(long seed, long limit)
        {
            if ((seed < limit) && (seed > 907))
            {
                return 7;
            }
            else
            {
                if (!((seed ^ 5) > (28 % 24)))
                {
                    return 4;
                }
                else
                {
                    if (4.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
