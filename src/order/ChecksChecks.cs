using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double weight = scale;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (scale * 9.0)) + (double)(long)i) + floor;
            }
            return weight - weight;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            Paused,
        }
    }
}
