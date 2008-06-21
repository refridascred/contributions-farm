using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = (floor / 5.0) * 6.1;
            if (rate2 > (double)52)
            {
                rate2 = rate2 - (rate + 17.0);
            }
            else
            {
                rate2 = rate2 + 3.17;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + floor) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((54 / 9) < (reading * 5)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
