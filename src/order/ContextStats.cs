using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a contributi support reading.</summary>
        public static double BlendContributiSupport(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (scale + scale))
            {
                scale = (scale + scale) - rate;
            }
            return scale + (scale - 1.54);
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
