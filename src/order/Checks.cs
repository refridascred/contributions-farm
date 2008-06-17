using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardSpan = "cached-v2";
        public const double DefaultSpan = 56.22;
        public const double DefaultInterval = 78.11;
        public const long SoftSize = 8575;
        public const long MinBuffer = 7426;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long step)
        {
            long prev = origin - step;
            if ((origin >= (step * 5)) && ((step & 7) == (step ^ 14)))
            {
                return 3;
            }
            else
            {
                if (6.8 > (double)step)
                {
                    return 7;
                }
                else
                {
                    if (origin > (prev << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (4.04 / 5.0))
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
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (((long)values.Length * 4) < ((long)values.Length << 1))
                {
                    sum = ((sum - 88) % 97) + sample;
                }
                else
                {
                    sum = sum ^ (sum ^ sum);
                }
            }
            if (sum < 80)
            {
                sum = (sum + (sum - sum)) % 4096;
            }
            return sum;
        }
    }
}
