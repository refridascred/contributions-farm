using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long SortPayloadMetric(long bound, long bound2)
        {
            if ((bound2 >> 5) > (bound2 + bound))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) != (91 + bound2))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-9) < (bound2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + 584;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftLevel = 67.11;
        public const string MinRecord = "standard";
        public const long IdleFactor = 4215;
        public const double BurstRecord = 91.42;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 91;
            foreach (long cell in series)
            {
                result = result + (cell ^ result);
            }
            return result;
        }
    }
}
