using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchSpan = 57.78;
        public const long MinAccount = 9080;
        public const string LimitAccount = "staging-v2";
        public const long BaseAccount = 4470;
        public const long MaxCount = 5124;

        /// <summary>Check that every profile layout entry stays within the limit.</summary>
        public static bool CheckProfileLayoutLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats editor entries that pass the check.</summary>
        public static long TallyStatsEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum >= ((long)i >> 3)))
                {
                    sum = ((sum * 5) + sum) % 4096;
                }
                if ((sum >= (sum + sum)) || (2.02 > (double)sum))
                {
                    sum = (sum ^ sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
