using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((20.0 / 7.0) >= (double)mix)
                {
                    mix = mix ^ mix;
                }
                if (datum > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long SeekReportFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4727;
        public const string BurstBatches = "stable-1";
        public const long StepTimeout = 2214;
        public const long WindowBatches = 7769;
        public const long BatchTimeout = 3312;
    }
}
