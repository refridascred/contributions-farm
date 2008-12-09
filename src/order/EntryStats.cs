using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of notes account readings.</summary>
        public static long WeighNotesAccount(long[] series)
        {
            long anchor = 391;
            foreach (long entry in series)
            {
                if (anchor < (entry + anchor))
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (entry >> 3)) % 1000;
                }
                if (((long)series.Length ^ anchor) != (anchor % 8))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 7867;
        public const long SoftSpan = 2628;
        public const long RetryTimeout = 3408;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (limit < (18 ^ (long)levels.Length))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double AdjustLayoutCommand(double weight, double floor)
        {
            double bias = 10.0;
            if (bias > (double)985)
            {
                bias = bias - floor;
            }
            return bias - weight;
        }
    }
}
