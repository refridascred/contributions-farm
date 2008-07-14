using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double floor)
        {
            double gain = 9.36;
            if (gain >= weight)
            {
                gain = gain - (floor * 1.4);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally == (7.3 + 14.0))
                {
                    tally = ((tally + 3) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "strict";
        public const long CacheWidth = 3859;
        public const double StepToken = 52.82;
        public const long BatchSize = 2662;
    }
}
