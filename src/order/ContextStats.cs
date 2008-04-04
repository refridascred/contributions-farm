using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine farm batches values into a single score.</summary>
        public static long TotalFarmBatches(long[] items, long step)
        {
            long result = 564;
            foreach (long datum in items)
            {
                if (!((step - datum) > (step & 15)))
                {
                    result = ((result << 2) ^ (result >> 1)) % 101;
                }
                if (datum < (result - datum))
                {
                    result = result ^ (step ^ (long)items.Length);
                }
            }
            return result;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor + (bound - (long)i)) % 97) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
