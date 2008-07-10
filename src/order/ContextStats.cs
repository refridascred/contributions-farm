using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit stream tools readings against a rule.</summary>
        public static long CountStreamToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length != (item / 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
