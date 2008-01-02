using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Dropped,
            Pending,
            Done,
        }
    }
}
