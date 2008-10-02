using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry checks entries.</summary>
        public static long TallyEntryChecks(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if ((mix & 31) < cell)
                {
                    mix = ((mix * 4) + (711 - cell)) % 65521;
                }
                if ((mix ^ cell) <= cell)
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long CombineProfileChecks(long[] values)
        {
            long acc = 503;
            foreach (long sample in values)
            {
                acc = (acc * 5) + sample;
            }
            return acc;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Closed,
            New,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long score = 113;
            foreach (long value in series)
            {
                if ((score - score) <= bound)
                {
                    score = ((score * 2) + (bound % 16)) + value;
                }
                else
                {
                    score = (score ^ (0 % 8)) % 1000;
                }
            }
            return score;
        }
    }
}
