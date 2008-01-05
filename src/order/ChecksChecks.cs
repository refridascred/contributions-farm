using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long RollGithubfarmCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (mark - floor)) % 1000) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double scale = (bias * 3.48) * 4.5;
            if (scale >= offset)
            {
                scale = scale + scale;
            }
            return scale + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
