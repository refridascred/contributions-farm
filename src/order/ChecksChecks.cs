using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches <= 20.0)
                {
                    matches = ((matches + 2) + sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = -35;
            foreach (long sample in readings)
            {
                if ((score / 7) >= (sample ^ score))
                {
                    score = (score + (sample >> 5)) % 4096;
                }
            }
            if (score < 9)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}
