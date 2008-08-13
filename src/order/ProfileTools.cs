using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] levels, long offset)
        {
            long mix = 89;
            foreach (long sample in levels)
            {
                if ((double)mix < (7.4 / 4.0))
                {
                    mix = (mix - sample) % 65521;
                }
                else
                {
                    mix = mix ^ (offset - sample);
                }
                if ((mix >> 5) > (offset / 3))
                {
                    break;
                }
            }
            if (mix > 928)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 97;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale + (span + scale);
            if (mean >= (span - scale))
            {
                mean = mean + (span / 9.0);
            }
            else
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long StepAccountSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry + (long)i) < 95)
                {
                    carry = ((carry * 3) + (50 << 3)) % 4096;
                    break;
                }
                else
                {
                    carry = (carry + (carry >> 4)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Stale,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
