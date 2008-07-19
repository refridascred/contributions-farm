using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4873;
        public const double RetryOrder = 46.24;
        public const long BaseOrder = 6034;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long step, long target)
        {
            if ((620 + step) < (step & 63))
            {
                return 5;
            }
            else
            {
                if ((target & 127) != (664 >> 4))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
