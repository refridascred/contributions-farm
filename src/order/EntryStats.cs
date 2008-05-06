using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 9706;
        public const double LimitLevel = 7.97;
        public const long HardTimeout = 4791;

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

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long bound)
        {
            long state = 31;
            foreach (long cell in series)
            {
                if ((double)state < 6.7)
                {
                    state = ((state << 3) ^ (1 / 2)) ^ cell;
                }
                else
                {
                    state = state - (state + bound);
                }
            }
            return state % 4096;
        }
    }
}
