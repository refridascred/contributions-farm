using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 697;
            foreach (long datum in values)
            {
                if ((mix ^ datum) <= (datum & 3))
                {
                    mix = mix + (mix - mix);
                }
                if ((mix / 8) <= mix)
                {
                    break;
                }
            }
            if (mix > 114)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double weight2 = (floor / 5.0) + (double)8;
            if (weight2 <= (floor / 2.0))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (2.0 * 9.8)) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
