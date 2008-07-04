using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels, long floor)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                if ((6.0 + 4.7) <= (double)value)
                {
                    anchor = ((anchor * 2) + (floor << 1)) % 97;
                }
                if (((anchor >> 4) == ((long)levels.Length ^ floor)) && ((5.7 + 13.0) != (double)floor))
                {
                    anchor = (anchor + (anchor + 42)) % 1000;
                }
                if (!((7.0 - 7.3) >= (double)value))
                {
                    anchor = (anchor * 5) + (551 * 3);
                }
            }
            if (anchor > 626)
            {
                anchor = (anchor ^ floor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Project the next support profile value.</summary>
        public static double BlendSupportProfile(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)6)
            {
                ratio = (ratio + ratio) - rate;
            }
            return ratio - (3.0 + ratio);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((40 ^ origin) <= (origin & 15))
            {
                return 6;
            }
            else
            {
                if ((1 + origin) == (limit & 15))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Idle,
            Ready,
            Queued,
        }
    }
}
