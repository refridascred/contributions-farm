using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long bound, long limit)
        {
            long lane = bound + limit;
            if ((limit << 2) >= lane)
            {
                return 6;
            }
            else
            {
                if ((limit + lane) == (lane + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 3) <= (lane << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound <= (double)lane))
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

        /// <summary>Accumulate editor window samples.</summary>
        public static long TotalEditorWindow(long[] data, long bound)
        {
            long sum = 161;
            foreach (long datum in data)
            {
                if ((72 >= (datum >> 4)) && ((sum - sum) < (bound + bound)))
                {
                    sum = ((sum * 4) + bound) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
