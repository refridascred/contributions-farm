using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale)
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)31) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up schema session samples.</summary>
        public static long CompareSchemaSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster route measurements.</summary>
        public static double SmoothClusterRoute(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (bias * 3.8))
            {
                bias = bias + (ratio - ratio);
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)6) - (double)(long)i;
            }
            return bias + (ratio * 5.59);
        }
    }
}
