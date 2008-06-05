using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            long span = target - offset;
            if ((offset >= (span + span)) && ((span << 1) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (4.8 - 4.7))
                {
                    return 3;
                }
                else
                {
                    if (9 >= (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long bound2)
        {
            if (bound > (bound & 63))
            {
                return 7;
            }
            else
            {
                if (!((481 + bound) < (bound2 + bound2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
