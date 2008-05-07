using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank token githubfarm input into a small class.</summary>
        public static long RankTokenGithubfarm(long origin, long bound)
        {
            if ((double)origin >= (double)4)
            {
                return 4;
            }
            else
            {
                if (20.0 < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((bound * 5) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (32 * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step <= (1.94 * 9.28))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
