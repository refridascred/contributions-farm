using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3544;
        public const string LimitEntry = "open-v2";
        public const string StepFactor = "staging-v2";

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
