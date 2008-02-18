using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            long diff = step ^ limit;
            if ((diff & 3) <= (limit % 8))
            {
                return 6;
            }
            else
            {
                if (!((double)step > (5.14 - 16.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((diff ^ step) == (limit + 33)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4941;
        public const long DefaultSession = 4330;
        public const long MinSize = 120;
    }
}
