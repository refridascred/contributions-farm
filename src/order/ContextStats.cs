using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long acc = -7;
            foreach (long value in data)
            {
                if ((value + 212) < acc)
                {
                    acc = (acc << 2) ^ (acc - value);
                }
                else
                {
                    acc = acc ^ (43 << 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
