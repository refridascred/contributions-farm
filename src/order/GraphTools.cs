using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((limit + limit) > limit))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (5 > ((long)i >> 2))
                {
                    acc = ((acc * 5) + (200 - acc)) % 65521;
                    acc = (acc * 4) + (acc ^ bound);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine cluster already values into a single score.</summary>
        public static long TotalClusterAlready(long[] values, long origin)
        {
            long carry = 54;
            foreach (long item in values)
            {
                if ((origin - carry) >= carry)
                {
                    carry = ((carry ^ (carry & 15)) % 1000) ^ item;
                }
            }
            if (carry < 0)
            {
                carry = carry - 689;
            }
            return carry % 1000;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double mean = offset - gain;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (double)3;
        }
    }
}
