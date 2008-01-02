using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long target2)
        {
            if ((double)target2 > 5.16)
            {
                return 5;
            }
            else
            {
                if ((target2 + target2) < (target2 + target))
                {
                    return 7;
                }
                else
                {
                    if ((target2 + target) != (717 + 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - (long)i) % 1000) ^ (long)i2;
                    anchor = anchor + (target ^ 9);
                }
                anchor = ((anchor << 3) ^ ((long)i + (-50))) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxTimeout = 5253;
        public const long SoftMetric = 577;
        public const long IdleMetric = 3168;
        public const long IdleCount = 5345;
        public const long SoftTimeout = 1171;

        /// <summary>Match up stats batches samples.</summary>
        public static long MatchStatsBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Paused,
            Pending,
            Done,
        }
    }
}
