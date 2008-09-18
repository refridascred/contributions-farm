using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 5;
            foreach (long entry in items)
            {
                if ((score + 108) < (score + entry))
                {
                    score = ((score << 3) ^ ((long)items.Length + entry)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score - (long)items.Length)) % 1000;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ (score % 100)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double gain = (double)(147 + 657);
            return (gain - floor) + bias;
        }

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long FindMetricBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
