using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long GradeBatchesTools(long origin, long seed)
        {
            if (!(origin <= (seed - origin)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed > 7.0))
                {
                    return 7;
                }
                else
                {
                    if (!(origin >= (origin - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
