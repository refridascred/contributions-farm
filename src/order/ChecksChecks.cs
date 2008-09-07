using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public double Level { get; set; }
        }
    }
}
