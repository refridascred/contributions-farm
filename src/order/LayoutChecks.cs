using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound <= (8 % 7))
                {
                    result = ((result << 2) ^ bound) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin <= (origin % 64))
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowWidth = "standard-edge";
        public const long SoftSession = 735;
        public const double BaseSession = 16.49;
        public const double LimitSession = 25.55;
    }
}
