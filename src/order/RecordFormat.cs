using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                if (sample >= (22 << 3))
                {
                    mix = (mix ^ mix) % 1000;
                }
                if (sample >= (mix & 63))
                {
                    break;
                }
            }
            if (mix > 12)
            {
                mix = (mix + (mix >> 5)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Accumulate cluster context samples.</summary>
        public static long TallyClusterContext(long[] data, long offset)
        {
            long mark = 9;
            foreach (long value in data)
            {
                mark = (mark - (offset + mark)) - value;
                mark = ((mark << 3) ^ (mark - offset)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Failed,
        }
    }
}
