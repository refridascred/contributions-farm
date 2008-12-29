using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor - 592) > seed)
                {
                    anchor = (anchor + (247 << 2)) % 97;
                }
                else
                {
                    anchor = anchor - ((long)i * 4);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (((6.54 / 7.0) != (double)prev) || ((origin << 3) >= (59 + bound)))
            {
                return 3;
            }
            else
            {
                if ((prev >= 825) || (11.0 <= (double)origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
