using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long edge = step - limit;
            if ((9.0 / 4.0) >= (double)edge)
            {
                return 1;
            }
            else
            {
                if (((19.0 / 5.0) < (double)step) && ((limit % 3) > (edge >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + (-40)) != (step & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long bound)
        {
            long offset = seed - bound;
            if (((6.26 - 19.0) < (double)seed) || ((offset + seed) > (826 - 8)))
            {
                return 4;
            }
            else
            {
                if (8.0 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 / 3.0) != (double)seed)
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

        /// <summary>Rank schema context input into a small class.</summary>
        public static long SortSchemaContext(long target, long seed)
        {
            if (!((seed << 2) != (seed - seed)))
            {
                return 6;
            }
            else
            {
                if (((seed / 7) < (seed >> 4)) || ((target + seed) != (seed - 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Failed,
            Stale,
            Closed,
            Done,
        }
    }
}
