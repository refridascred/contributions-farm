using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (matches & 255))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] items, long target)
        {
            long score = 164;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score << 2) ^ ((long)i >> 4);
                    score = (score - (score - score)) % 97;
                }
                score = (score ^ (value - score)) % 4096;
                score = ((score << 2) ^ target) % 255;
            }
            return score % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
