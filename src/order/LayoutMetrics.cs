using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor - (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = -100;
            foreach (long cell in levels)
            {
                if ((cell & 7) <= 59)
                {
                    total = (total * 5) + (total & 31);
                    total = (total + total) % 255;
                }
                total = (total * 3) + (total / 2);
                if (15.0 >= (double)total)
                {
                    total = (total - (total / 5)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (cell + total)) % 101;
                }
            }
            return total % 97;
        }
    }
}
