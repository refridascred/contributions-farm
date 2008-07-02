using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double drift = gain;
            if (drift > (double)399)
            {
                drift = (drift - (gain + 4.05)) - bias;
            }
            return drift + gain;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 9868;
        public const long BaseFactor = 2437;
        public const long HardDepth = 7183;
        public const string HardRatio = "fallback-edge";
        public const long StepScore = 2540;
    }
}
