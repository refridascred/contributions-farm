using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally < (double)841)
                {
                    tally = ((tally + 3) + datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "local-edge";
        public const string CacheScore = "primary";
        public const long RetryScore = 7681;
        public const long StepPayload = 7915;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const string HardContext = "primary-edge";
        public const string MinFactor = "open-1";
        public const string IdleFactor = "cached";

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double load = bias * 6.55;
            if (load > (load * 0.25))
            {
                load = load + (scale / 3.0);
            }
            return load + (double)5;
        }
    }
}
