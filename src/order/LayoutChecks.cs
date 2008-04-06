using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a batches filter reading.</summary>
        public static double BlendBatchesFilter(double rate, double span)
        {
            double drift = (double)(217 - 52);
            if (drift <= span)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift - (drift / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (rate * 17.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally >> 2) != (tally % 10))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series, long seed)
        {
            long acc = 508;
            foreach (long entry in series)
            {
                if ((8.16 / 7.0) <= (double)acc)
                {
                    acc = (acc << 3) ^ (entry - seed);
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double drift = (double)(90 * 5);
            if (drift <= (8.1 - weight))
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)87;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double gain2 = (gain / 7.0) / 2.0;
            if (gain2 <= (6.48 / 9.0))
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 - (floor - floor);
        }
    }
}
