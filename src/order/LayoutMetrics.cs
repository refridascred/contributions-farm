using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i * 3) < seed))
                {
                    score = score ^ (seed ^ (long)i);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + score) ^ (long)i2;
                }
                if ((double)seed == (16.0 + 14.0))
                {
                    score = ((score * 4) + (seed << 3)) % 101;
                    score = ((score * 3) + ((long)i + score)) % 97;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
