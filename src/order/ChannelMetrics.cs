using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 67;
            foreach (long sample in data)
            {
                if ((double)mark <= (1.3 - 0.9))
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = ((mark * 5) + sample) % 101;
                }
            }
            if (mark < 407)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Rank already notes input into a small class.</summary>
        public static long BucketAlreadyNotes(long offset, long limit)
        {
            if ((5.02 * 9.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((offset + offset) < (2 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 1) >= (588 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset > (limit + offset)) && ((limit - offset) <= (offset * 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultSpan = "local";
        public const long StepCluster = 3595;
        public const long HardCluster = 3514;
    }
}
