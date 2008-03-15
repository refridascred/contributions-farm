using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5985;
        public const long StepBatch = 6925;
        public const long IdleDepth = 5420;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Done,
            Queued,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
