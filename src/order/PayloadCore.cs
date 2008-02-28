using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values, long floor)
        {
            long anchor = 237;
            foreach (long item in values)
            {
                anchor = anchor ^ (item + floor);
                if (19.0 > (double)item)
                {
                    anchor = (anchor ^ 51) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 6550;
        public const long RetryContext = 9691;
        public const long StepContext = 1079;
        public const long RetryScore = 8618;

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool GuardNotesBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
