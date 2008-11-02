using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long seed)
        {
            if ((4.3 + 3.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((double)step > (4.1 + 12.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step / 6) == (seed / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + mix) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long floor)
        {
            long offset = limit - floor;
            if (offset >= (floor + limit))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 8.2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
