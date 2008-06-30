using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Failed,
            New,
            Stale,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (8.1 - offset)) + (double)(long)i) + ratio;
            }
            return drift + (drift * 3.66);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
