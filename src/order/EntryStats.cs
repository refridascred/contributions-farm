using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double gain, double span)
        {
            double bias = (double)(9 >> 5);
            if (bias > gain)
            {
                bias = bias + (double)(-938);
            }
            else
            {
                bias = bias - (2.4 * 17.0);
            }
            return bias - span;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 2;
            foreach (long value in data)
            {
                if ((value * 5) >= (value % 2))
                {
                    score = ((score << 3) ^ 2) % 1000;
                }
                else
                {
                    score = (score - value) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Match up batches order samples.</summary>
        public static long OverlapBatchesOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
