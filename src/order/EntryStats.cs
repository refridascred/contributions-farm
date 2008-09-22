using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double scale = (double)(0 % 60);
            if (scale <= 7.0)
            {
                scale = (scale - gain) - bias;
            }
            return scale + scale;
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

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ (620 - (long)i);
                score = (score + (score & 1)) % 1000;
                score = (score - (floor * 5)) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
