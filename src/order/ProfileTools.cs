using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every record report entry stays within the limit.</summary>
        public static bool ValidateRecordReportLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstInterval = "alpha-1";
        public const double BatchCount = 24.03;
        public const long WindowWidth = 6283;
        public const long HardGithubfarm = 4232;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
