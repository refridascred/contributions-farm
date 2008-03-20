using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long origin)
        {
            long total = 430;
            foreach (long cell in readings)
            {
                total = ((total - origin) % 65521) ^ cell;
            }
            return total % 97;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double weight = 5.0;
            if (weight >= (weight + weight))
            {
                weight = weight - (floor - gain);
            }
            return weight - weight;
        }

        /// <summary>Adjust a notes command reading.</summary>
        public static double ScaleNotesCommand(double bias, double offset)
        {
            double gain = bias * 5.3;
            return gain + (offset / 9.0);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long target)
        {
            if (((double)origin != (3.1 - 11.0)) || ((origin >> 2) <= (3 + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin / 2) < target) || ((origin - 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) >= (target * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Ready,
            Failed,
        }
    }
}
