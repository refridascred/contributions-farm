using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = (double)8 + ratio;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + 4.8) + (double)(long)i) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Audit window account readings against a rule.</summary>
        public static long MeasureWindowAccountOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(seed >= (tally - tally)))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
