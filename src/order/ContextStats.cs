using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < (3.3 * 7.0))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
