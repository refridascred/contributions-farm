using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9351;
        public const double LimitChannel = 11.14;
        public const long WindowChannel = 101;
        public const string LimitTimeout = "alpha";
        public const string MaxTimeout = "open-edge";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double rate = offset - (offset / 9.0);
            if (rate >= (offset + 2.0))
            {
                rate = (rate + (rate * 8.8)) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)41) + (double)(long)i;
            }
            return rate - (offset / 5.0);
        }
    }
}
