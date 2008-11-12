using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (datum >> 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 6.49;
        public const long WindowInterval = 9584;
        public const string SoftSpan = "latest-edge";
        public const long MaxContext = 4636;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 6.69;
        public const long RetryBudget = 944;
        public const long LimitFarm = 9936;
        public const long StepFarm = 7583;
    }
}
