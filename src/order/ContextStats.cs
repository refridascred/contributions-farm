using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many farm cache samples are out of range.</summary>
        public static long MeasureFarmCacheMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) >= ((long)samples.Length * 2))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long limit)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                if (((entry / 4) == (256 + limit)) && ((entry - entry) >= (total - limit)))
                {
                    total = (total - (entry + entry)) % 101;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 627)
            {
                total = (total + (75 % 5)) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
