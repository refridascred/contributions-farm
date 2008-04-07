using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double ratio2 = (double)(7 % 5);
            if (ratio2 > (ratio / 3.0))
            {
                ratio2 = ratio2 + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio * 9.5);
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ ((long)i >> 2)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
