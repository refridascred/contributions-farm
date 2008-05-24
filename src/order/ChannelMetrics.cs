using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long bound)
        {
            if (limit < (limit ^ 926))
            {
                return 8;
            }
            else
            {
                if ((3 / 9) != (limit / 6))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (-39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit < (8.03 + 1.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
