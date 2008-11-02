using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a contributi stats value against two limits.</summary>
        public static long GradeContributiStats(long step, long step2)
        {
            if (((79 + step2) <= step2) && ((step + step2) <= (step2 % 7)))
            {
                return 0;
            }
            else
            {
                if ((11.0 * 0.84) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultWidth = 9218;
        public const long IdleSchema = 9059;
        public const long CacheFactor = 9856;
        public const double BaseSchema = 49.34;

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches >= (matches - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
