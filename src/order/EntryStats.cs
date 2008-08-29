using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double rate2 = (rate / 5.0) * 4.53;
            if (rate2 >= bias)
            {
                rate2 = rate2 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + bias;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = 40;
            foreach (long sample in samples)
            {
                if ((sample + result) <= (result << 2))
                {
                    result = ((result * 5) + result) % 97;
                }
                if ((result - sample) >= (sample * 2))
                {
                    result = result - (result - sample);
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Synced,
            Active,
            Paused,
        }
    }
}
