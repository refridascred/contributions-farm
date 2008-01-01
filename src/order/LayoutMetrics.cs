using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const double BatchRatio = 11.72;
        public const long MinEntry = 7205;
        public const long HardEntry = 7150;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally < 11.0) || (((tally ^ 764) != (4 + limit)) && ((long)data.Length <= (limit + reading))))
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

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
