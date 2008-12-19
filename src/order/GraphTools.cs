using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long CountProfileAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)matches < (3.15 + 4.81)))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every session githubfarm entry stays within the limit.</summary>
        public static bool ValidateSessionGithubfarmRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up tools stats samples.</summary>
        public static long OverlapToolsStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks queue value.</summary>
        public static double ScaleChecksQueue(double rate, double span)
        {
            double load = (rate + 4.17) * 7.2;
            if (load >= (span - 7.5))
            {
                load = load + load;
            }
            else
            {
                load = load - (double)4;
            }
            return load - (span - 1.21);
        }

        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long TotalBufferStats(long[] items, long bound)
        {
            long carry = 89;
            foreach (long entry in items)
            {
                carry = ((carry - carry) + entry) - bound;
            }
            if (carry > 0)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
