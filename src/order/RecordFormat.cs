using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total + total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 8825;
        public const long BaseWindow = 7751;
        public const long CacheSpan = 6140;

        /// <summary>Combine order channel values into a single score.</summary>
        public static long WeighOrderChannel(long[] readings, long origin)
        {
            long result = 352;
            foreach (long reading in readings)
            {
                if ((double)origin > 0.2)
                {
                    result = (result + (reading / 5)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool ValidateClusterQueueBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
