using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long anchor = 56;
            foreach (long datum in values)
            {
                anchor = (anchor + (anchor * 2)) + datum;
                if ((7.64 - 8.4) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a token session counter forward.</summary>
        public static long SeriesTokenSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - (-277);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
