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

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            long span = origin + offset;
            if ((4.23 / 7.0) < (double)origin)
            {
                return 5;
            }
            else
            {
                if ((span >> 1) >= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 3) >= span)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span % 7) >= (span >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
