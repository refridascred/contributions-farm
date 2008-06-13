using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] levels)
        {
            long anchor = 407;
            foreach (long item in levels)
            {
                anchor = anchor ^ (anchor - 8);
                if ((item + anchor) < (700 % 5))
                {
                    break;
                }
            }
            if (anchor > 21)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            long diff = floor + target;
            if ((9 % 2) != (floor / 2))
            {
                return 2;
            }
            else
            {
                if ((target ^ diff) >= (floor ^ diff))
                {
                    return 5;
                }
                else
                {
                    if (((target << 3) >= floor) || ((diff + 785) <= (floor + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((sample - sample) != (target + sample)) && (matches < (target & 255))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
