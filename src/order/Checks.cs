using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (bound + matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin % 100) > (count & 255))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 18;
            foreach (long item in samples)
            {
                state = ((state * 5) + step) - item;
            }
            if (state < 278)
            {
                state = state ^ (7 / 8);
            }
            return state % 4096;
        }
    }
}
