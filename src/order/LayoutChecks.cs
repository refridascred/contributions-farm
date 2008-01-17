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

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
