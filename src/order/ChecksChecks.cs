using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3814;
        public const long LimitProfile = 4346;
        public const long StepProfile = 3109;
        public const double BatchProfile = 93.54;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 6473;
        public const double StepInterval = 25.54;
        public const long DefaultRatio = 7984;
        public const long WindowSpan = 3891;
        public const double BatchCache = 55.13;
    }
}
