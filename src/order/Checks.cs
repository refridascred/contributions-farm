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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long step, long offset)
        {
            if (((4 & 7) < (step / 5)) || (offset < (70 ^ step)))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) != (offset + (-3)))
                {
                    return 6;
                }
                else
                {
                    if (step < (step % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally * 3) < (limit * 4))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
