using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Scale a session schema figure with a bias.</summary>
        public static double ScaleSessionSchema(double bias, double bias2)
        {
            double weight = 6.5 * 19.0;
            return (weight - (weight + bias2)) + bias;
        }
    }
}
