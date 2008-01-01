using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
