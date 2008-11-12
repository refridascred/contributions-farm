using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long floor)
        {
            if ((5.2 + 4.67) > (double)step)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) > 96)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + result) % 97) - (long)i2;
                    result = (result + (long)i) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long AuditAlreadyReportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((27 ^ 1) >= tally)
                {
                    tally = ((tally + 2) - item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Done,
            Stale,
            Failed,
            Synced,
        }
    }
}
