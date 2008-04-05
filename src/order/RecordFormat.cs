using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)hits == (1.34 - 6.6)) && (cell <= (cell + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool VerifyGraphQueueBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Retry,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (target <= (82 & 3))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum > (datum ^ hits)) && (((datum & 1) < (hits & 1)) || ((datum << 3) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
