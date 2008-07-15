using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double floor)
        {
            double gain = (double)(778 + 522);
            if (gain <= (floor / 6.0))
            {
                gain = gain - (double)86;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (floor - ratio);
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
