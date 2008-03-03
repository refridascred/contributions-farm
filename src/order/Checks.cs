using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload account samples.</summary>
        public static long CombinePayloadAccount(long[] levels)
        {
            long carry = 10;
            foreach (long datum in levels)
            {
                carry = (carry - (carry - (-28))) - datum;
            }
            if (carry < 7)
            {
                carry = ((carry * 4) + (45 % 7)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long AuditContributiSupportOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((2 ^ 83) == (792 + step))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count != (7.2 / 4.0))
                {
                    count = ((count + 2) + item) - bound;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 7915;
        public const long HardBatch = 9284;
        public const long SoftBatch = 9538;
        public const long IdleInterval = 7157;
    }
}
