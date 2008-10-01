using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                long cur = ((long)i / 9) + floor;
                if ((state > (state << 1)) && ((state ^ state) < (state + cur)))
                {
                    cur = (cur * 5) + (532 / 9);
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load - (span + 3.0);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
