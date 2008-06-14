using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "alpha";
        public const long MinCommand = 1635;
        public const long BurstBudget = 3549;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long GradeOrderBuffer(long limit, long seed)
        {
            if ((1 & 255) <= (limit * 5))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) >= seed) && ((double)127 > (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) != (6 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((24 << 2) < (seed >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
