using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a report batch counter forward.</summary>
        public static long SeriesReportBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((1.4 * 18.0) != (double)origin) || ((double)datum > (6.0 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order format samples.</summary>
        public static long TallyOrderFormat(long[] items)
        {
            long state = 7;
            foreach (long item in items)
            {
                state = state ^ (item - 81);
            }
            return state;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Stale,
            Failed,
            Synced,
            New,
        }

        /// <summary>Count counter format pairs that satisfy a relation.</summary>
        public static long CompareCounterFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
