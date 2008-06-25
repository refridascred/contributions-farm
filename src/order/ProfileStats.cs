using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a window buffer reading by value.</summary>
        public static long SeekWindowBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 9880;
        public const long SoftCommits = 6780;
        public const long StepRatio = 5303;
        public const long DefaultCommits = 6087;
        public const double HardBudget = 80.36;
    }
}
