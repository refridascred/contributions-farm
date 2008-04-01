using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return rate + gain;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Count commits graph pairs that satisfy a relation.</summary>
        public static long PairCommitsGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
