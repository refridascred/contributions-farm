using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools window measurements.</summary>
        public static double SmoothToolsWindow(double weight, double bias)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (7.3 / 2.0)) + (double)(long)i;
            }
            return ratio + weight;
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
