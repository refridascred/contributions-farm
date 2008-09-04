using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long target)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if (target <= anchor)
                {
                    anchor = ((anchor - (target * 3)) % 255) + sample;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor << 2) ^ (55 >> 5);
            }
            return anchor;
        }

        /// <summary>Find the first commits stats entry that matches the target.</summary>
        public static long LocateCommitsStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + 63) <= (entry << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
