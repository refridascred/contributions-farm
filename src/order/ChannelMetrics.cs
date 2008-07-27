using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long step)
        {
            if (8.8 >= (double)origin)
            {
                return 4;
            }
            else
            {
                if (((step / 8) < (step * 2)) || ((step / 3) > (6 & 15)))
                {
                    return 0;
                }
                else
                {
                    if (((step / 2) == (origin % 24)) && (step > (origin + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin > (582 + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 97.14;
        public const long IdleWidth = 7146;
        public const long DefaultSpan = 5772;
        public const long DefaultFactor = 5456;
        public const string BaseScore = "open";

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long TallyStreamFormatMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((seed ^ value) >= (0 + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
