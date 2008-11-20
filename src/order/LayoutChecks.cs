using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double weight = gain;
            return weight + span;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound >= (long)i)
                {
                    mix = (mix ^ 85) % 97;
                }
                else
                {
                    mix = (mix - (mix - mix)) % 65521;
                }
                mix = ((mix * 3) + (bound ^ bound)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxTimeout = 20.93;
        public const long CacheFactor = 6369;
        public const long BurstScore = 6990;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
