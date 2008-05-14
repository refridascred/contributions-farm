using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long CountClusterRecordHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.6 / 2.0) >= (double)reading)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
