using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((limit - limit) >= (count & 7))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long DigestToolsWindow(long[] series)
        {
            long result = -326;
            foreach (long datum in series)
            {
                if (((11.0 - 2.0) < (double)datum) && ((double)result <= (2.44 / 3.0)))
                {
                    result = (result - 750) % 101;
                }
                else
                {
                    result = (result - (datum + 33)) % 4096;
                }
                if (((double)result <= (6.0 / 6.0)) && (datum < (datum / 9)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
