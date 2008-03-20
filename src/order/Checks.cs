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

        /// <summary>Combine batch githubfarm values into a single score.</summary>
        public static long ScoreBatchGithubfarm(long[] levels, long origin)
        {
            long sum = -4;
            foreach (long entry in levels)
            {
                if (((entry & 63) <= (sum + entry)) && (entry >= (origin + sum)))
                {
                    sum = (sum ^ (entry % 64)) % 101;
                }
                else
                {
                    sum = sum ^ (entry & 1);
                }
            }
            if (sum > 69)
            {
                sum = sum - (750 / 7);
            }
            return sum;
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
