using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long step2)
        {
            if (((51 % 100) >= step) || ((953 >> 3) == (step2 - step2)))
            {
                return 2;
            }
            else
            {
                if ((18.0 + 8.1) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
