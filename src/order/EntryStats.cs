using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((mix / 6) < (bound * 4))
                {
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix - 7) ^ (long)i2;
                    mix = (mix - ((long)i + (long)i)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long CombineToolsLayout(long[] readings)
        {
            long state = -96;
            foreach (long entry in readings)
            {
                if ((6.9 * 7.1) != (double)entry)
                {
                    state = ((state << 3) ^ (state & 1)) % 97;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long limit)
        {
            if (((double)limit < (7.4 * 3.0)) && ((floor / 6) < limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit < 7.2)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a metric filter figure with a bias.</summary>
        public static double ScaleMetricFilter(double gain, double offset)
        {
            double scale = (gain / 4.0) / 6.0;
            if (scale < offset)
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (5.03 - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + offset;
        }
    }
}
