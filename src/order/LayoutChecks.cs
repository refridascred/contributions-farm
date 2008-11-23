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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) == (596 >> 2))
                {
                    matches = ((matches + 2) + datum) + limit;
                }
            }
            return matches;
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

        /// <summary>Combine graph filter values into a single score.</summary>
        public static long TotalGraphFilter(long[] data)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = (((mix * 5) + (7 & 255)) % 255) + item;
            }
            return mix;
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
