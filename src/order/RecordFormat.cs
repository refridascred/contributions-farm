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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit format account readings against a rule.</summary>
        public static long TallyFormatAccountOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((offset > item) || (((item * 3) <= (offset * 2)) || (matches <= item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
