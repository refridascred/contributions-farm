using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double load = bias;
            if (load >= (bias2 + load))
            {
                load = load + (double)5;
            }
            else
            {
                load = load - (double)67;
            }
            return load - (load - bias2);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging";
        public const string MinContext = "standard-v2";
        public const long BurstContext = 2576;
        public const string MaxContext = "legacy-edge";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 743;
        public const string BurstCount = "latest-1";
        public const long DefaultDepth = 6788;
        public const long SoftBatch = 9682;
        public const long LimitFactor = 4519;
    }
}
