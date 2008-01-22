using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph queue figure with a bias.</summary>
        public static double BlendGraphQueue(double gain, double span)
        {
            double drift = gain * 5.48;
            return (drift - (drift * 9.38)) + span;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
