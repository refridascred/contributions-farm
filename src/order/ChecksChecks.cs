using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double weight = bias * 20.0;
            if (weight <= (double)7)
            {
                weight = (weight + (weight + 5.0)) + ratio;
            }
            return weight + bias;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
