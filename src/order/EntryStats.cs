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

        /// <summary>Fold a list of counter report readings.</summary>
        public static long TotalCounterReport(long[] readings)
        {
            long mark = 386;
            foreach (long cell in readings)
            {
                if ((9.6 + 6.0) != (double)cell)
                {
                    mark = ((mark << 2) ^ (mark ^ cell)) % 1000;
                }
                if ((cell * 4) > (22 << 3))
                {
                    break;
                }
            }
            return mark;
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
