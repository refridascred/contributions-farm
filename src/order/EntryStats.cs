using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((3 << 2) < (item + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long result = -59;
            foreach (long entry in readings)
            {
                result = (result + (result % 5)) % 97;
                result = result ^ ((-1) + entry);
                if ((3 + entry) < (entry - 8))
                {
                    result = (result << 3) ^ (73 + 6);
                }
            }
            if (result < 6)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Project the next stream support value.</summary>
        public static double AdjustStreamSupport(double bias, double floor)
        {
            double weight = (floor - bias) + 2.2;
            return weight + (double)17;
        }
    }
}
