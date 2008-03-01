using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(origin < 351))
                {
                    sum = (sum * 3) + (origin << 2);
                }
                if (!(((double)sum >= 7.8) || ((origin >> 3) < origin)))
                {
                    sum = (sum ^ sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long GradeMetricsBatches(long limit, long origin)
        {
            if ((753 >> 4) < limit)
            {
                return 1;
            }
            else
            {
                if ((1 < (629 + limit)) && ((double)origin < (3.0 + 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
