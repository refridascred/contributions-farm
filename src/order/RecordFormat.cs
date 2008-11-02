using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardSize = "fallback-v2";
        public const long BaseFactor = 8548;
        public const double LimitFarm = 39.64;
        public const long DefaultFarm = 3967;
        public const string MaxWidth = "stable-v2";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Pending,
            Retry,
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long FindBatchCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
