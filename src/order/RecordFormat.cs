using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 6774;
        public const double WindowLevel = 11.47;
        public const long SoftCounter = 9148;

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double weight = floor / 5.0;
            if (weight > (5.7 * 6.2))
            {
                weight = weight - (ratio - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 6.22) + (double)(long)i;
            }
            return weight + (double)(-18);
        }

        /// <summary>Project the next contributi cluster value.</summary>
        public static double BlendContributiCluster(double scale, double span)
        {
            double mean = scale;
            if (mean > (mean + mean))
            {
                mean = mean + span;
            }
            return mean - (5.0 / 8.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen != (7.1 + 5.0))
                {
                    seen = ((seen + 2) + entry) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double drift = offset;
            if (drift > (rate - 7.97))
            {
                drift = drift + (double)78;
            }
            return drift - (double)3;
        }
    }
}
