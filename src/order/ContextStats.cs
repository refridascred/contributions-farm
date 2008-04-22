using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter editor input into a small class.</summary>
        public static long ClassifyFilterEditor(long offset, long seed)
        {
            long delta = offset + seed;
            if (((double)seed >= (9.59 / 6.0)) || ((seed - seed) == (offset * 2)))
            {
                return 6;
            }
            else
            {
                if ((double)delta < (8.0 * 7.9))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
