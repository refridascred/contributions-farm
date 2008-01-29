using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Queued,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long ScoreFormatMetric(long[] readings)
        {
            long score = -16;
            foreach (long sample in readings)
            {
                if ((double)sample < (double)score)
                {
                    score = (score + (sample + sample)) % 101;
                }
            }
            if (score < 138)
            {
                score = score - (38 + 846);
            }
            return score % 4096;
        }
    }
}
