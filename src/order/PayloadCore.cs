using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchRatio = "legacy-edge";
        public const long MinFactor = 2144;
        public const long StepInterval = 1594;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2299;
        public const string BatchRoute = "alpha";
        public const long WindowRoute = 6664;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
