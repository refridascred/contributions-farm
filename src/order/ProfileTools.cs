using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((-644) >= (cell + count))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long BucketOrderAccount(long floor, long offset)
        {
            long bound = floor - offset;
            if ((floor - offset) > floor)
            {
                return 6;
            }
            else
            {
                if ((27 >> 3) <= (floor % 7))
                {
                    return 0;
                }
                else
                {
                    if (bound >= (offset % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor == (8.0 + 5.32))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool VerifyCacheProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
