using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit batch schema readings against a rule.</summary>
        public static long MeasureBatchSchemaMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches < (bound + 13)) && (cell <= (cell - cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
