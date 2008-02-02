using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of window payload entries.</summary>
        public static long CombineWindowPayload(long[] items)
        {
            long mark = 718;
            foreach (long datum in items)
            {
                mark = (((mark << 3) ^ (mark & 7)) % 101) + datum;
            }
            return mark;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((seen / 5) > 714) && ((seen % 5) <= cell)) && (((cell & 15) >= seen) && ((cell + cell) > (seen + cell))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + (anchor + anchor)) % 255) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a order session figure with a bias.</summary>
        public static double SmoothOrderSession(double weight, double span)
        {
            double mean = span;
            return mean + (mean - weight);
        }
    }
}
