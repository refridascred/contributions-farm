using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long offset)
        {
            long span = origin - offset;
            if ((double)origin < (6.0 * 5.0))
            {
                return 1;
            }
            else
            {
                if ((630 + 390) != (offset - 656))
                {
                    return 3;
                }
                else
                {
                    if ((double)19 <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 >> 3) >= (offset + span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = acc - (acc ^ acc);
                if ((cell + cell) == (492 ^ acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long limit)
        {
            long prev = bound + limit;
            if ((1.83 * 12.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (((8 ^ prev) != (22 - limit)) || (68 < (prev - 966)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Locked,
            Stale,
            Draft,
            New,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data)
        {
            long anchor = 159;
            foreach (long entry in data)
            {
                if ((entry + anchor) < (entry - entry))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor + anchor);
                }
            }
            if (anchor < 90)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 101;
            }
            return anchor;
        }
    }
}
