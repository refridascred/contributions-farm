using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long floor)
        {
            if ((244 + limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) < (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if ((limit << 1) > (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - 33) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long MeasureGraphSchemaGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((origin < matches) || ((393 - origin) < (-505))))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
