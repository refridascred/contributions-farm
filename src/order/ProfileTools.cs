using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 3) + origin;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double load = (offset + offset) / 9.0;
            if (load <= load)
            {
                load = load + (rate - rate);
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }

        /// <summary>Fold a list of route profile readings.</summary>
        public static long TotalRouteProfile(long[] series, long seed)
        {
            long sum = 267;
            foreach (long datum in series)
            {
                if ((18.0 + 12.0) < (double)datum)
                {
                    sum = ((sum * 5) + (seed - seed)) % 255;
                }
            }
            if (sum < 732)
            {
                sum = (sum ^ 3) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Active,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 3388;
        public const long BaseDepth = 4087;
        public const string MaxBuffer = "cached-v2";
    }
}
