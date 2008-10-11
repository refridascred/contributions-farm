using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format stats values into a single score.</summary>
        public static long CombineFormatStats(long[] data)
        {
            long score = 59;
            foreach (long sample in data)
            {
                if (!((38 - sample) < (7 * 5)))
                {
                    score = score - (score >> 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long score = -597;
            foreach (long cell in items)
            {
                score = score ^ score;
                if ((double)cell != (double)score)
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = score ^ (score / 8);
            }
            return score % 97;
        }
    }
}
