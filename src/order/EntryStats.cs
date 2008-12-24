using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double drift = gain;
            if (drift <= (16.0 + gain))
            {
                drift = (drift + 2.0) - bias;
            }
            else
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)47) + (double)(long)i;
            }
            return drift + (double)8;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double gain = weight;
            if (gain > (double)541)
            {
                gain = (gain - (5.07 * 3.08)) + span;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + weight;
        }
    }
}
