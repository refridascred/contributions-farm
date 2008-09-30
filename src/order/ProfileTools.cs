using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if ((floor << 3) != (step & 31))
            {
                return 5;
            }
            else
            {
                if ((step & 1) >= (690 * 2))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (step + 795))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 655) < (step ^ 44))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long MeasureSchemaBatchesGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((12 > matches) || ((offset + 329) >= matches)) && ((offset - matches) == (offset + sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
