using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a order notes counter forward.</summary>
        public static long StepOrderNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (8 >= ((long)i ^ seed))
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor + step) < (step % 2))
                {
                    anchor = ((anchor << 2) ^ (step << 1)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Ready,
            Dropped,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
