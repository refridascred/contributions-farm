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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mix = 42;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ ((-7) + cell)) % 65521) - seed;
            }
            return mix % 1000;
        }
    }
}
