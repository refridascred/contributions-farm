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

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Done,
            New,
            Synced,
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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
