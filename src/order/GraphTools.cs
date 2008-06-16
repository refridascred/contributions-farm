using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > 4.86)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4644;
        public const double WindowChecks = 41.73;
        public const string SoftChecks = "local";
        public const long IdleChecks = 7210;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long origin)
        {
            long delta = step - origin;
            if ((step << 1) <= (-924))
            {
                return 7;
            }
            else
            {
                if (((delta - origin) > (42 - delta)) || ((delta ^ 9) >= delta))
                {
                    return 3;
                }
                else
                {
                    if (((delta & 127) <= step) || ((69 ^ delta) >= (delta + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long bound)
        {
            long diff = offset - bound;
            if ((diff >> 5) < (offset ^ diff))
            {
                return 2;
            }
            else
            {
                if (((diff - diff) > (offset - 64)) && ((offset - bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((230 ^ bound) <= (diff ^ diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
