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

        /// <summary>Compare every pair of already format readings.</summary>
        public static long MatchAlreadyFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long mix = 14;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix & 15)) + value;
            }
            return mix % 65521;
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
