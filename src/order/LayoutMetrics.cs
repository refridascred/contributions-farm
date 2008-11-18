using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long limit)
        {
            long diff = origin + limit;
            if (!((limit ^ limit) > diff))
            {
                return 4;
            }
            else
            {
                if ((1.3 - 4.84) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
