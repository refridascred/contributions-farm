using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long CountGraphStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length & 15) != (706 / 2))
                {
                    seen = ((seen + 2) - datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm token value against two limits.</summary>
        public static long SortGithubfarmToken(long origin, long offset)
        {
            if ((offset ^ 48) >= (offset & 1))
            {
                return 0;
            }
            else
            {
                if (((origin >> 1) > (offset / 5)) || ((13.0 / 9.0) == (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (offset > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Failed,
            Active,
            New,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Idle,
            Stale,
            Pending,
        }
    }
}
