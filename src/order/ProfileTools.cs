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

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double load = floor;
            if (load > (double)8)
            {
                load = load + (floor * 8.34);
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load - 3.9)) + (double)(long)i;
            }
            return load + floor;
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
