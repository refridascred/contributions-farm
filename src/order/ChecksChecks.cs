using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 89.55;
        public const double DefaultSchema = 76.77;
        public const long BatchSchema = 4879;
        public const string StepSchema = "fallback-edge";
        public const long BaseSchema = 1320;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((9.4 / 2.0) <= (double)datum) && ((floor << 1) > datum))
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Idle,
            Closed,
        }
    }
}
