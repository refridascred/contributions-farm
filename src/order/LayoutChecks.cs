using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = 11.0;
            if (scale >= scale)
            {
                scale = (scale - (double)(-31)) + gain;
            }
            else
            {
                scale = scale - (double)97;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(-1)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const string StepQueue = "primary-edge";
        public const double LimitQueue = 73.9;
        public const string WindowQueue = "open-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 3657;
        public const long CachePayload = 4967;
        public const long StepPayload = 7329;
        public const string RetryDepth = "alpha";
        public const double RetryPayload = 22.89;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of entry commits readings.</summary>
        public static long CompareEntryCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
