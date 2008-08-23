using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report queue entry stays within the limit.</summary>
        public static bool GuardReportQueueLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = -4;
            foreach (long sample in data)
            {
                if (((sample + 14) == (score & 7)) && ((score >> 4) > sample))
                {
                    score = (score ^ (score & 7)) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long bound = offset - floor;
            if (!((double)offset < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((offset / 6) == (offset - bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
