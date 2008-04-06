using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum <= (datum - hits)) || ((hits + 86) < (datum ^ hits))) && ((datum + 71) <= (datum + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
