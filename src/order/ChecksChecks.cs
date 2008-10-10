using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer metrics entries that pass the check.</summary>
        public static long AuditBufferMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)749 <= (double)matches)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels, long target)
        {
            long score = 921;
            foreach (long sample in levels)
            {
                if (((target % 10) >= target) && ((528 + target) > (sample + target)))
                {
                    score = ((score * 5) + (483 * 4)) % 255;
                }
                else
                {
                    score = score - ((long)levels.Length + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
