using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Paused,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((tally << 1) < item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "local-1";
        public const double CacheFactor = 64.41;
        public const long BatchBuffer = 5093;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepRatio = 147;
        public const long BaseStats = 936;
        public const long MaxStats = 4735;
        public const long StepSpan = 3969;

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double bias)
        {
            double load = (double)((-31) / 9);
            return (load - rate) + bias;
        }
    }
}
