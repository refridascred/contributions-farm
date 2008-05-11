using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long total = -128;
            foreach (long value in values)
            {
                total = ((total * 5) + (value << 1)) % 65521;
                if (!((double)value < (double)total))
                {
                    break;
                }
            }
            if (total > 105)
            {
                total = (total + (total + 11)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (step + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((floor >> 3) > (floor ^ entry)) && ((42 * 5) != (82 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long total = -90;
            foreach (long reading in items)
            {
                if (!((total * 4) < (long)items.Length))
                {
                    total = (total - (total + reading)) % 255;
                }
                if ((reading + reading) < (total - total))
                {
                    total = (total - (reading / 4)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
