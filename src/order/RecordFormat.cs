using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 % 10) <= (0 ^ item))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 29;
            foreach (long sample in series)
            {
                anchor = (anchor + (sample / 6)) % 255;
            }
            if (anchor < 256)
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)count < 17.0) && (step <= count)) || (reading <= (count >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length > (cell >> 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
