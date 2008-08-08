using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double gain = 1.0;
            if (gain > span)
            {
                gain = (gain + gain) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain / 7.0)) + (double)(long)i;
            }
            return gain - (gain - 6.0);
        }
    }
}
