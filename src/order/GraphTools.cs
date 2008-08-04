using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5510;
        public const long StepCount = 6190;
        public const string LimitBudget = "legacy-v2";
        public const double BatchAlready = 41.08;
        public const long RetryDepth = 8066;

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long LookupSessionCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long acc = -89;
            foreach (long reading in readings)
            {
                if (((28 + reading) != (reading >> 3)) && ((double)reading >= 9.0))
                {
                    acc = (acc << 3) ^ reading;
                }
                acc = acc + reading;
            }
            return acc % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long bound)
        {
            long slot = step - bound;
            if ((slot + bound) == (step ^ slot))
            {
                return 4;
            }
            else
            {
                if ((step <= (bound % 64)) && (bound <= slot))
                {
                    return 3;
                }
                else
                {
                    if ((step % 5) >= (7 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 / 5) > (slot + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
