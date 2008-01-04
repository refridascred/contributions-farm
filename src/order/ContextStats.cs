using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + ((long)i * 3)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 26;
            foreach (long item in items)
            {
                if ((double)anchor > (double)item)
                {
                    anchor = (anchor + (anchor + item)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if ((double)item > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (item + (-218))) % 1000;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double weight2 = (3.0 - floor) + (weight - 3.8);
            if (weight2 > (double)86)
            {
                weight2 = weight2 - (floor - floor);
            }
            return weight2 + (floor - weight);
        }
    }
}
