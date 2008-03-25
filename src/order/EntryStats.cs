using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a buffer order counter forward.</summary>
        public static long DeriveBufferOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ bound) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8256;
        public const string CacheInterval = "primary";
        public const long CacheChannel = 9391;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                if ((result - (long)readings.Length) >= (result << 2))
                {
                    result = (result + (result + 181)) % 255;
                }
                else
                {
                    result = (result - (result + cell)) % 1000;
                }
            }
            return result % 97;
        }
    }
}
