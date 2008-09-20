using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double scale = (double)11 / 6.0;
            if (scale <= scale)
            {
                scale = (scale + offset) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 1.35) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Stale,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long seed)
        {
            long carry = 968;
            foreach (long datum in levels)
            {
                carry = (carry - seed) + datum;
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Dropped,
            Pending,
            Idle,
        }
    }
}
