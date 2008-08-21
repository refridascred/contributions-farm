using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long limit)
        {
            if ((floor & 255) < (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit + 374) <= (floor + 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheInterval = 203;
        public const double BatchChannel = 33.78;
        public const long IdleSpan = 3372;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long offset)
        {
            if ((limit ^ offset) >= (offset - offset))
            {
                return 5;
            }
            else
            {
                if (offset < (limit * 4))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
