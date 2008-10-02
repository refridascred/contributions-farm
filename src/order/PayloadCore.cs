using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double bias2 = 0.3;
            if (bias2 < gain)
            {
                bias2 = bias2 - (0.29 - bias);
            }
            else
            {
                bias2 = bias2 + (9.6 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (double)587;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long AuditBatchChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((limit * 5) > 5)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
