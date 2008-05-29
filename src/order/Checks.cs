using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if (8 <= ((long)i - 725))
                {
                    sum = (sum - sum) % 1000;
                    sum = (sum * 5) + ((long)i << 1);
                }
                if ((sum / 8) != (floor ^ sum))
                {
                    sum = (sum - floor) % 65521;
                    sum = (sum - (floor - sum)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long TallyTokenBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count != (double)34) || ((double)count != (8.75 + 3.0)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next schema checks value.</summary>
        public static double AdjustSchemaChecks(double gain, double offset)
        {
            double load = offset * 6.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (offset + offset)) - (double)(long)i) - gain;
            }
            return load - (double)88;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
