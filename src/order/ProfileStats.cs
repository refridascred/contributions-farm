using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine buffer session values into a single score.</summary>
        public static long FoldBufferSession(long[] samples)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (score >= (score ^ entry))
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long origin)
        {
            long step = offset - origin;
            if ((double)step > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((1.32 + 2.6) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (12.0 * 0.8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 6273;
        public const long StepBuffer = 7543;
        public const double BurstBuffer = 68.78;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long floor)
        {
            long cur = step - floor;
            if ((step & 3) >= (step ^ step))
            {
                return 0;
            }
            else
            {
                if ((double)cur >= (4.59 + 9.85))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 24) < (84 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)cur == (5.6 / 8.0)) || ((cur - 291) <= (513 / 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
