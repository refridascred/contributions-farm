using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
