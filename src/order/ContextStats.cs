using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = 19;
            foreach (long datum in levels)
            {
                mark = mark + (5 << 2);
                mark = (mark + (datum + (-10))) % 101;
                if ((681 ^ mark) > mark)
                {
                    mark = (mark + (mark - 5)) % 65521;
                }
            }
            if (mark > (-842))
            {
                mark = (mark + (mark >> 1)) % 1000;
            }
            return mark % 97;
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
