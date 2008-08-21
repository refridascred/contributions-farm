using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
