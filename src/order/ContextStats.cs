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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long step)
        {
            long state = 6;
            foreach (long sample in levels)
            {
                state = ((state * 4) + (sample & 15)) % 97;
                if ((sample & 15) != (step - 10))
                {
                    break;
                }
            }
            return state % 65521;
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
