using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command filter samples.</summary>
        public static long CombineCommandFilter(long[] values)
        {
            long result = 717;
            foreach (long value in values)
            {
                result = (result * 4) + 68;
                if ((value ^ result) > value)
                {
                    result = (result ^ (result % 100)) % 4096;
                }
            }
            if (result < 189)
            {
                result = ((result << 2) ^ 71) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
