using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double bias)
        {
            double ratio = (bias * 0.08) / 4.0;
            return (ratio - (5.18 + ratio)) + rate;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((seed >> 2) < (item - seed))
                {
                    hits = hits + 3;
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
