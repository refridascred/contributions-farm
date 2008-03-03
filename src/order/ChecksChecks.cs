using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long score = 896;
            foreach (long reading in levels)
            {
                if ((score - offset) >= (reading - offset))
                {
                    score = (score + (offset + 525)) % 1000;
                }
                if (((offset * 3) <= (reading << 1)) || ((score - offset) >= (reading << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 7580;
        public const long HardContributi = 4160;
        public const double MaxContributi = 27.02;
        public const string BatchCount = "standard-1";
        public const double StepContributi = 53.36;
    }
}
