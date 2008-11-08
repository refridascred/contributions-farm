using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long IterateQueueCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ acc) % 1000;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)matches <= 5.0) && !(matches > (640 - reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
