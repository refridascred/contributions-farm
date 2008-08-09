using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitTimeout = 2207;
        public const string BurstBuffer = "standard-edge";
        public const long DefaultWidth = 8380;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double weight = offset * 4.0;
            if (weight > (rate - rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + offset;
        }
    }
}
