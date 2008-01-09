using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 82;
            foreach (long value in data)
            {
                if ((value & 3) > (anchor + anchor))
                {
                    anchor = (anchor - (607 << 3)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long bound)
        {
            if (!((14.0 + 1.7) > (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit - bound) != (2 & 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-9) & 15) != (bound & 3))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
