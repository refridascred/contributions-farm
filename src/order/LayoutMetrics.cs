using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long GradeBufferPayload(long floor, long floor2)
        {
            if (((floor - floor) >= (floor2 ^ 876)) || ((double)floor2 <= (6.34 + 8.9)))
            {
                return 1;
            }
            else
            {
                if ((floor2 / 7) != (26 + floor))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor2 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (446 <= (floor2 & 7))
                        {
                            return 4;
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
