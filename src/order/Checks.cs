using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((total / 4) < (target + target))
                {
                    total = (total + (1 + target)) % 4096;
                }
                total = ((total * 5) + total) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if ((double)seed >= (2.63 + 1.0))
            {
                return 2;
            }
            else
            {
                if ((offset - seed) == (2 ^ 777))
                {
                    return 7;
                }
                else
                {
                    if (!((offset - seed) != (seed & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
