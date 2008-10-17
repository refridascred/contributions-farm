using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (double)(long)i) - scale;
            }
            return scale2 + (span * 3.3);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target << 1) <= (state / 6))
                {
                    state = (state << 2) ^ state;
                    state = (state + (long)i) % 97;
                    continue;
                }
                state = (state + ((-3) / 3)) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
