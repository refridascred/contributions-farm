using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((offset <= offset2) && ((floor + offset) > (offset & 1)))
            {
                return 7;
            }
            else
            {
                if ((floor / 7) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank commits stream input into a small class.</summary>
        public static long SortCommitsStream(long seed, long origin)
        {
            if ((double)origin > (0.2 * 10.0))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (1.0 * 16.0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double rate = (double)(-511) / 3.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
