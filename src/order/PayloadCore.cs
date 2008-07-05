using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(7.1 >= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
