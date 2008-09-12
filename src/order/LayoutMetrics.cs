using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long floor)
        {
            long anchor = 30;
            foreach (long datum in items)
            {
                if ((3.23 * 6.0) <= (double)datum)
                {
                    anchor = (anchor ^ (long)items.Length) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum - 32);
                }
                if ((double)datum != (0.6 / 4.0))
                {
                    break;
                }
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (floor / 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.0 - rate)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
