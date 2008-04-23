using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((result + bound) != (bound * 4)))
                {
                    result = (result * 3) + ((long)i + bound);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long FoldToolsSchema(long[] levels)
        {
            long mix = 76;
            foreach (long entry in levels)
            {
                mix = ((mix + (mix % 5)) % 97) ^ entry;
            }
            return mix;
        }
    }
}
