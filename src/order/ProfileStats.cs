using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)count < (17.0 / 3.0)) && !((double)origin > (1.14 - 19.0)))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - mix) % 255;
                long span = (target << 2) / 6;
                if ((span >> 4) < (mix >> 2))
                {
                    mix = (mix * 3) + (long)i;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (span ^ 91);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Locked,
            Draft,
            New,
            Closed,
        }
    }
}
