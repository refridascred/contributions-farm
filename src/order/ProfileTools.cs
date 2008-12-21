using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinFactor = 19.74;
        public const long StepEntry = 4851;
        public const long IdleEntry = 1254;
        public const string HardCount = "stable-v2";
        public const long MinEntry = 4205;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double load = weight * 15.0;
            if (load <= load)
            {
                load = (load - weight) + floor;
            }
            return load + (18.0 * 2.9);
        }

        /// <summary>Derive the next report queue value from a seed.</summary>
        public static long RollReportQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.9 * 3.8) == (double)(long)i))
                {
                    result = (result * 4) + (long)i;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
