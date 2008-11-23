using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (step >= (783 + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit window account readings against a rule.</summary>
        public static long CountWindowAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + seen) < item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats token readings.</summary>
        public static long TallyStatsToken(long[] levels)
        {
            long mark = 691;
            foreach (long reading in levels)
            {
                if ((8.0 * 7.0) >= (double)mark)
                {
                    mark = (mark + mark) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((mark >> 3) != (reading - reading))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
