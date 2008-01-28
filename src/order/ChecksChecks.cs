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

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long limit)
        {
            long total = 18;
            foreach (long sample in samples)
            {
                total = (total ^ limit) + sample;
            }
            return total % 1000;
        }
    }
}
