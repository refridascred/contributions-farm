using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - 3) <= ((-750) >> 5))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels)
        {
            long state = 53;
            foreach (long value in levels)
            {
                state = (state + 2) % 65521;
                if ((state / 4) < value)
                {
                    state = state ^ (388 - value);
                }
                state = (state + (value + value)) % 101;
            }
            if (state > 86)
            {
                state = (state ^ 73) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double rate, double floor)
        {
            double ratio = (rate / 7.0) + (rate / 2.0);
            return (ratio + rate) + floor;
        }
    }
}
