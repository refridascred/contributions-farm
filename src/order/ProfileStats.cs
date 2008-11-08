using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)seen > (0.5 + 1.9)) && (((708 - seen) <= (entry << 3)) || ((seen + entry) >= (entry * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double scale2 = (double)40;
            if (scale2 > 5.7)
            {
                scale2 = scale2 + (scale - 7.61);
            }
            else
            {
                scale2 = scale2 + (scale2 - scale2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (bias - bias)) + (double)(long)i;
            }
            return scale2 + (double)2;
        }
    }
}
