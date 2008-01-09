using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double bias2 = (rate - 9.7) / 9.0;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches ^ cell) != (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Failed,
            Synced,
        }
    }
}
