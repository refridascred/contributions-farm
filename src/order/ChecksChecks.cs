using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Queued,
            Draft,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
