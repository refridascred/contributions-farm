using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ total) % 65521;
                total = (total ^ ((long)i >> 2)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long CountEditorFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((76 ^ count) > count)
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
