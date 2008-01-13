using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultBudget = 9239;
        public const long BatchTimeout = 8322;
        public const double DefaultLevel = 26.78;
        public const string MaxDepth = "standard-1";
        public const long HardEntry = 9246;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
