using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (mean - mean)) - scale;
            }
            return mean - mean;
        }

        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] levels)
        {
            long carry = 84;
            foreach (long cell in levels)
            {
                carry = (carry ^ (cell - 90)) % 1000;
                if ((736 ^ (long)levels.Length) < (carry + 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 94.8;
        public const long MaxLevel = 5378;
        public const string MinFactor = "primary-1";

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(5.6 < (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
