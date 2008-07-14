using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double ratio = gain - (double)364;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (1.19 * 5.4)) + (double)(long)i) + offset;
            }
            return ratio + (double)2;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
