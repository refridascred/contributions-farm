using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)step != (double)acc))
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits > (double)4)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
