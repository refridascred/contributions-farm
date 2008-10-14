using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long CountWindowToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((672 + (-92)) < (cell / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long TallyClusterCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((955 + reading) != (reading - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (-82)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
