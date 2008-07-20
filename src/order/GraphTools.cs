using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank route buffer input into a small class.</summary>
        public static long BucketRouteBuffer(long floor, long bound)
        {
            long diff = floor + bound;
            if ((double)diff > (6.9 - 20.0))
            {
                return 8;
            }
            else
            {
                if ((13 & 63) != (258 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (7.6 - 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two route record measurements.</summary>
        public static double ProjectRouteRecord(double rate, double offset)
        {
            double load = offset + rate;
            if (load >= (offset / 5.0))
            {
                load = load - load;
            }
            return load - offset;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next notes commits value from a seed.</summary>
        public static long SeriesNotesCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!(anchor <= seed))
                {
                    anchor = (anchor - (anchor + anchor)) % 65521;
                    anchor = anchor - (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Done,
            Idle,
            Retry,
        }
    }
}
