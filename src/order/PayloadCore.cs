using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the report order series from a seed.</summary>
        public static long DeriveReportOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 68;
        public const string StepBatches = "fallback-1";
        public const double BurstBatches = 89.49;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (seen / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
