using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double weight = (bias / 4.0) / 9.0;
            if (weight <= (bias - bias2))
            {
                weight = weight + bias2;
            }
            return weight + (weight + bias);
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
