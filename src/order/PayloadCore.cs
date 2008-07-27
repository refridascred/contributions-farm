using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - item) > (tally - 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 3211;
        public const double HardNotes = 96.96;
        public const long MaxLevel = 5314;

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                mark = (mark + (cell + cell)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
