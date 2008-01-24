using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of commits stream readings.</summary>
        public static long TallyCommitsStream(long[] readings, long limit)
        {
            long carry = 4;
            foreach (long sample in readings)
            {
                if ((sample - sample) > carry)
                {
                    carry = carry ^ (20 + (-480));
                }
                else
                {
                    carry = (carry + limit) % 1000;
                }
                if ((carry > (652 / 6)) && ((double)carry == (4.78 - 6.78)))
                {
                    break;
                }
            }
            if (carry < 75)
            {
                carry = carry - (carry - limit);
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Validate account counter readings against a bound.</summary>
        public static bool VerifyAccountCounterBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
