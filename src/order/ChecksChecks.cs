using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long step, long bound)
        {
            long slot = step + bound;
            if (((slot + slot) <= slot) && ((double)step > (0.24 + 8.88)))
            {
                return 8;
            }
            else
            {
                if ((step + step) > bound)
                {
                    return 4;
                }
                else
                {
                    if ((step < (slot << 1)) && ((5 - slot) == (bound * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes record sample.</summary>
        public static long LocateNotesRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
