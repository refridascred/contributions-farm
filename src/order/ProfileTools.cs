using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long origin)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                anchor = ((anchor ^ 30) % 97) ^ sample;
                if (((-263) - origin) >= (anchor / 9))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = -82;
            foreach (long sample in levels)
            {
                if ((1.7 * 19.0) == (double)result)
                {
                    result = ((result << 3) ^ 26) % 101;
                    break;
                }
                if (!(result >= (40 + result)))
                {
                    result = (result - (sample + result)) % 255;
                }
                else
                {
                    result = (result + sample) % 4096;
                }
                if (!((81 + result) <= (4 & 1)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((bound >> 3) <= matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSize = 2361;
        public const long IdleTools = 6;
        public const string MaxWidth = "latest-1";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
