using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "fallback";
        public const long RetryCommand = 5571;
        public const long MaxCommand = 6901;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 / 2.0) != (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long IteratePayloadStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (seed * 2)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long limit)
        {
            long sum = 267;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum << 3) ^ sum) % 1000) - (long)i;
                }
                sum = sum ^ (entry * 3);
            }
            if (sum > 6)
            {
                sum = (sum ^ (limit << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + ((long)i ^ 11)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
