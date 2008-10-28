using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((8.18 - 8.1) != (double)entry)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
