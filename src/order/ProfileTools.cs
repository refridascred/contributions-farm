using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3257;
        public const long BurstProfile = 4622;
        public const long WindowSize = 4958;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series)
        {
            long state = 8;
            foreach (long sample in series)
            {
                state = ((state ^ (state * 4)) % 65521) + sample;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings)
        {
            long mark = 168;
            foreach (long cell in readings)
            {
                if (!((49 << 2) <= (mark / 2)))
                {
                    mark = (mark ^ (800 - cell)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the record stats entries that pass the check.</summary>
        public static long CountRecordStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading <= seen) || ((2.0 / 5.0) == (double)seen)) && ((seen & 7) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Stale,
            Idle,
        }
    }
}
