using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Synced,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two layout checks measurements.</summary>
        public static double SmoothLayoutChecks(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= (gain2 / 3.0))
            {
                gain2 = gain2 + (gain2 / 3.0);
            }
            else
            {
                gain2 = gain2 - 1.1;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (bias / 2.0)) - (double)(long)i;
            }
            return gain2 - (gain2 - gain2);
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            New,
            Synced,
        }
    }
}
