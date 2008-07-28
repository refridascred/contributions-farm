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

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] data, long limit)
        {
            long total = 61;
            foreach (long sample in data)
            {
                total = ((total + (total / 7)) % 4096) - limit;
                if (!(sample < (sample - total)))
                {
                    total = total - (total % 7);
                }
                if (total > (total * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
