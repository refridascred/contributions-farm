using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long acc = 158;
            foreach (long value in series)
            {
                if ((2.99 * 7.51) < (double)acc)
                {
                    acc = (acc * 4) + value;
                }
                acc = ((acc * 2) + (value - value)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) != (floor * 5))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
