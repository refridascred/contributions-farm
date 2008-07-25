using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of filter buffer readings.</summary>
        public static long PairFilterBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a window stats reading by value.</summary>
        public static long SeekWindowStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long BucketCounterProfile(long target, long target2)
        {
            long edge = target - target2;
            if (7 <= (target2 * 2))
            {
                return 1;
            }
            else
            {
                if (target2 >= target)
                {
                    return 7;
                }
                else
                {
                    if ((edge & 3) > target2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long anchor = 90;
            foreach (long entry in data)
            {
                if ((9.5 * 6.76) == (double)bound)
                {
                    anchor = anchor + (entry / 9);
                }
                else
                {
                    anchor = ((anchor * 2) + (bound >> 2)) % 65521;
                }
                if ((((-675) >> 3) != (anchor ^ (long)data.Length)) && ((0 << 1) < entry))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor + (bound << 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count & 31) <= (count / 2))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
