using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if ((target % 100) > ((long)i ^ 0))
                {
                    result = (result ^ (target ^ 891)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result + 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up account metric samples.</summary>
        public static long PairAccountMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer route samples are out of range.</summary>
        public static long CountBufferRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) != (count - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
