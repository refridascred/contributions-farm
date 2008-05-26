using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LocateToolsBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long GradeContributiBuffer(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (((8 + delta) < (delta - origin)) && ((delta & 7) < (211 / 7)))
            {
                return 1;
            }
            else
            {
                if ((origin & 127) == (origin % 97))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta + origin) < (origin + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
