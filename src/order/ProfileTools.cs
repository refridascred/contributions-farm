using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count + (-6)) <= (value >> 2)) || ((value % 10) != (floor * 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double mean = (double)49 * 8.7;
            if (mean >= (1.75 - 3.6))
            {
                mean = (mean + mean) - gain;
            }
            else
            {
                mean = mean - (offset - offset);
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double weight2 = (weight - weight) * 7.73;
            if (weight2 < (double)259)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            return weight2 - floor;
        }

        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long AuditGraphProfileMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit < (matches - matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
