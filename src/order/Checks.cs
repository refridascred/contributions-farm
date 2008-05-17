using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 1216;
        public const long RetryScore = 280;
        public const double BaseGithubfarm = 6.86;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Stale,
            New,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                carry = carry ^ (value ^ value);
            }
            if (carry > 3)
            {
                carry = ((carry * 3) + (106 << 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long BucketBatchesContext(long offset, long target)
        {
            if ((target % 3) != (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((20.0 * 9.6) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.0 - 4.0) > (double)target) && ((offset + offset) != (9 - 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command schema values into a single score.</summary>
        public static long TallyCommandSchema(long[] levels)
        {
            long mix = 4;
            foreach (long sample in levels)
            {
                if ((mix > (sample / 8)) || ((double)sample < (0.81 / 4.0)))
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ mix) % 4096;
                }
                if ((mix % 24) > 4)
                {
                    mix = (mix - (mix + mix)) % 101;
                }
            }
            return mix;
        }
    }
}
