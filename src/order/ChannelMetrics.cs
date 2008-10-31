using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 8687;
        public const long BurstFactor = 1318;
        public const long BaseCommand = 721;
        public const string DefaultCommand = "fallback-edge";
        public const double HardWidth = 43.32;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 124;
            foreach (long sample in levels)
            {
                if (((sample / 8) >= (sample >> 1)) && ((result - result) > result))
                {
                    break;
                }
                else
                {
                    result = result - result;
                }
                if ((3.0 / 4.0) >= (double)result)
                {
                    result = result ^ result;
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 4766;
        public const double IdleAlready = 52.21;
        public const long WindowSpan = 7506;
    }
}
