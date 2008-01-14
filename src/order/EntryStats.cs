using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-1";
        public const long StepAlready = 9956;
        public const long RetrySpan = 6038;
        public const string HardAlready = "strict-1";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] samples, long offset)
        {
            long total = 181;
            foreach (long sample in samples)
            {
                if (offset < (offset * 3))
                {
                    total = (total ^ sample) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool ValidateStreamProfileBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stream support figure with a bias.</summary>
        public static double ScaleStreamSupport(double ratio, double bias)
        {
            double drift = (6.83 / 8.0) - (double)416;
            if (drift <= (ratio - 2.04))
            {
                drift = (drift - 5.7) + bias;
            }
            return drift - 6.0;
        }
    }
}
