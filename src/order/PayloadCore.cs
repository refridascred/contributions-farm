using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound + acc) > (bound - (-2)))
                {
                    acc = (acc ^ 735) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long DigestReportStream(long[] readings)
        {
            long mark = 812;
            foreach (long cell in readings)
            {
                if (((cell % 60) > 7) && ((mark + cell) >= cell))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long step)
        {
            if ((floor <= (floor + step)) || ((floor + 0) != (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step ^ floor) > (796 + step))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (step ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
