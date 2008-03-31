using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1525;
        public const long WindowWidth = 9826;
        public const long RetryLevel = 8803;
        public const long CacheProfile = 8081;
        public const long MaxRatio = 5538;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long step)
        {
            if (!((step & 15) <= bound))
            {
                return 5;
            }
            else
            {
                if ((step + step) != (step - step))
                {
                    return 3;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ bound) == (step / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = 51;
            foreach (long item in data)
            {
                if ((4.0 + 6.3) <= (double)item)
                {
                    sum = sum + (item % 60);
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum % 8)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) >= (datum - datum))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
