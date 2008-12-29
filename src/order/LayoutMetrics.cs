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

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long anchor = 377;
            foreach (long datum in items)
            {
                if ((datum - anchor) > (anchor >> 4))
                {
                    anchor = (anchor - (45 + datum)) % 255;
                }
                else
                {
                    anchor = (anchor ^ 7) % 97;
                }
                if ((anchor * 5) < (anchor * 3))
                {
                    break;
                }
            }
            if (anchor < 972)
            {
                anchor = ((anchor << 2) ^ 589) % 1000;
            }
            return anchor;
        }
    }
}
