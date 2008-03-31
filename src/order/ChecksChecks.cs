using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 6429;
        public const long BaseStream = 4832;
        public const string WindowStream = "legacy-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - 76) >= (long)readings.Length)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Synced,
            Closed,
        }
    }
}
