using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 6426;
        public const long HardWidth = 2115;
        public const long SoftInterval = 9078;
        public const long StepBatch = 7332;
        public const long HardFactor = 3991;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long step)
        {
            long score = 22;
            foreach (long cell in values)
            {
                score = (score << 2) ^ (step - score);
                if ((step - cell) <= (step + 8))
                {
                    break;
                }
            }
            if (score > 485)
            {
                score = score - (step + 141);
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
