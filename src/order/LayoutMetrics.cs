using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes batches counter forward.</summary>
        public static long DeriveNotesBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool CheckRouteStatsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
