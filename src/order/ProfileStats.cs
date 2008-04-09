using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = (mark - 8) % 65521;
                if ((datum * 3) < datum)
                {
                    mark = mark - (datum - datum);
                }
                if (0 >= (79 + datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepInterval = 64.74;
        public const string MaxMetrics = "legacy-1";
        public const long IdleMetrics = 6291;
        public const double SoftMetrics = 20.33;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Active,
            Pending,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (double)591)
            {
                scale = (scale - bias) + bias2;
            }
            return scale + (double)76;
        }
    }
}
