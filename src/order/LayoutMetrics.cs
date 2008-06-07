using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long limit)
        {
            long sum = 46;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ value) % 97;
                if ((value - limit) != (value + sum))
                {
                    sum = ((sum * 3) + 2) % 65521;
                    sum = (sum - ((long)series.Length - 552)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (limit + limit)) % 65521;
                }
                if ((limit > (6 % 24)) || (((long)series.Length & 127) < (limit - value)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
                if ((double)limit > (double)31)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
