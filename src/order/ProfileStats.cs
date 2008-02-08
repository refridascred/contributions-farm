using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data, long step)
        {
            long state = 7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state ^ (state << 3)) ^ (long)i) - reading) - step;
                }
                state = ((state << 3) ^ (7 / 3)) % 4096;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long step)
        {
            if ((step - step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) < (step + 6))
                {
                    return 8;
                }
                else
                {
                    if ((step - origin) != (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin <= (step & 31)))
                        {
                            return 7;
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
