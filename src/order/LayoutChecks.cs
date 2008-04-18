using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheScore = 33.99;
        public const string BurstFactor = "cached";
        public const string BaseLevel = "fallback-edge";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            New,
            Queued,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long limit)
        {
            long span = target - limit;
            if ((span - 628) >= limit)
            {
                return 2;
            }
            else
            {
                if ((30 >= (target + target)) || (limit < ((-28) - limit)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
