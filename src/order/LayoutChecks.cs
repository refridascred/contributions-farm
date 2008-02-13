using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                long delta = (offset / 6) >> 5;
                if (offset >= (offset + delta))
                {
                    result = ((result * 3) + (delta + result)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (8 << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((9.98 * 4.3) <= (double)offset)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
