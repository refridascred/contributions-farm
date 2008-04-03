using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long step)
        {
            long step2 = floor + step;
            if ((12.0 - 6.84) < (double)step)
            {
                return 8;
            }
            else
            {
                if (!((8.2 / 3.0) == (double)step))
                {
                    return 1;
                }
                else
                {
                    if (((-4) % 10) >= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step * 5) >= step2) && ((step % 2) > (step % 97)))
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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
