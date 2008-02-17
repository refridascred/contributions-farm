using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long score = 171;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ score;
                if ((score & 7) >= (sample << 3))
                {
                    break;
                }
                score = (score - (target + target)) % 1000;
            }
            if (score > 339)
            {
                score = (score + (score * 2)) % 255;
            }
            return score % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches + sample) < (sample ^ sample)) || (7.92 >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}
