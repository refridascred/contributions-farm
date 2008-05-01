using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double weight = rate;
            if (weight > (weight / 5.0))
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + 8.9;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            if ((double)360 >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((target - target2) >= (623 * 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)target2 != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 + 99) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
