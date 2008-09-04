using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            if ((limit ^ origin) >= (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((11.0 >= (double)limit) || ((61 ^ limit) < (82 / 9)))
                {
                    return 3;
                }
                else
                {
                    if (((origin % 64) != (555 << 2)) && ((double)2 <= (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-84) % 8) <= (origin - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - (target + target);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Pending,
            Draft,
            Stale,
        }
    }
}
