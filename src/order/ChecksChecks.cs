using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits < (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((155 % 3) > (27 ^ cell))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
