using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine batches editor values into a single score.</summary>
        public static long TallyBatchesEditor(long[] samples)
        {
            long mix = -1;
            foreach (long value in samples)
            {
                if ((571 + mix) >= value)
                {
                    mix = mix - 6;
                }
                else
                {
                    mix = (mix + (value & 31)) % 97;
                }
                if ((value <= (mix / 7)) && (mix <= 396))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((18.0 - 0.2) != (double)count)
                {
                    count = ((count + 1) + cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
