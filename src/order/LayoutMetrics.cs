using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor checks readings against a bound.</summary>
        public static bool VerifyEditorChecksLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark + limit)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
