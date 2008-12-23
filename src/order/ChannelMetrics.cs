using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long offset)
        {
            long sum = 617;
            foreach (long sample in levels)
            {
                if (sum <= (sample + sum))
                {
                    sum = ((sum - sum) % 255) - offset;
                }
            }
            if (sum < 448)
            {
                sum = (sum - ((-73) / 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3929;
        public const long LimitInterval = 176;
        public const long DefaultBuffer = 9858;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((double)offset <= (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((404 + 77) != (offset - 168))
                {
                    return 2;
                }
                else
                {
                    if ((double)337 != (double)bound2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 6) == ((-24) + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
