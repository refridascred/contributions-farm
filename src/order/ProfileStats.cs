using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool VerifyOrderBatchesBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value != (5.0 * 13.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (2 > (seen >> 1))
                {
                    seen = ((seen + 1) + sample) - step;
                }
            }
            return seen;
        }
    }
}
