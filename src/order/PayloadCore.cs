using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LocateToolsBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i ^ 368) > (result % 16)) && ((result / 9) >= (origin ^ 145)))
                {
                    result = result ^ ((long)i % 8);
                }
                long count = result;
                if ((double)count < (7.0 + 8.85))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
