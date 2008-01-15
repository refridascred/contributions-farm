using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                state = ((state * 2) + (state % 97)) ^ value;
                state = (state << 2) ^ (state + 7);
            }
            if (state > 3)
            {
                state = (state + (state - (-82))) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 493;
        public const long MaxChannel = 5705;
        public const long BatchTimeout = 5121;
        public const string BatchChannel = "local";

        /// <summary>Grade a record entry value against two limits.</summary>
        public static long ClassifyRecordEntry(long bound, long step)
        {
            if (((step % 64) <= step) && ((double)bound <= (14.0 + 6.52)))
            {
                return 3;
            }
            else
            {
                if ((step > (step - bound)) || ((bound % 16) < step))
                {
                    return 7;
                }
                else
                {
                    if (((step >> 1) <= (step * 4)) || ((double)bound == (17.0 - 0.9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
