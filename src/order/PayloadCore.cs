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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples)
        {
            long result = 143;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result ^ (956 & 7)) % 1000) + entry;
                    result = result + (long)i;
                }
                result = ((result << 3) ^ (result + result)) % 1000;
            }
            if (result < 53)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
