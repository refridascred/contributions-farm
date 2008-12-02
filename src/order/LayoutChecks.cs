using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 18.73;
        public const long SoftTimeout = 5813;
        public const long StepEntry = 3626;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Look up the position of a buffer record sample.</summary>
        public static long LocateBufferRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long seed)
        {
            if ((step - 52) <= (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (38 & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
