using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank filter batches input into a small class.</summary>
        public static long GradeFilterBatches(long limit, long seed)
        {
            long cur = limit + seed;
            if ((8.0 + 19.0) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((limit % 3) >= (cur + 0))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) <= (cur / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next command checks value from a seed.</summary>
        public static long StepCommandChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = ((state << 2) ^ (9 & 1)) % 4096;
                state = state + (offset / 4);
                state = (state * 3) + ((long)i + 776);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultFactor = "cached";
        public const long MaxCounter = 6075;
        public const long RetryCounter = 6144;
        public const long DefaultSize = 5961;

        /// <summary>Measure how many githubfarm contributi samples are out of range.</summary>
        public static long CountGithubfarmContributiHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= 353)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
