using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((9 - cell) <= 5)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream token figure with a bias.</summary>
        public static double ScaleStreamToken(double weight, double bias)
        {
            double gain = (double)(6 * 2);
            if (gain < (weight + bias))
            {
                gain = gain - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
