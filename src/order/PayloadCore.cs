using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double mean = (double)(5 / 6);
            if (mean <= (double)614)
            {
                mean = (mean + (bias * 1.0)) - floor;
            }
            return mean - (double)0;
        }

        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long StepProfileToken(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total - (long)i)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long TallyCacheGithubfarm(long[] items, long offset)
        {
            long result = -9;
            foreach (long reading in items)
            {
                result = (result - (3 - offset)) % 1000;
                result = result - (result + reading);
                if ((reading + reading) > (-896))
                {
                    result = result + (reading % 5);
                }
                if ((0.43 * 15.0) != (double)offset)
                {
                    break;
                }
            }
            return result;
        }
    }
}
