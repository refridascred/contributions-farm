using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheRatio = 88.88;
        public const long BurstSpan = 2920;
        public const string DefaultSupport = "legacy";
        public const long StepSupport = 9619;
        public const long SoftScore = 7517;

        /// <summary>Digest a series of report metric entries.</summary>
        public static long ScoreReportMetric(long[] levels, long step)
        {
            long score = -204;
            foreach (long sample in levels)
            {
                long tally = (949 >> 4) / 6;
                if ((tally + 99) >= (step & 255))
                {
                    tally = tally - (7 + tally);
                    break;
                }
                else
                {
                    score = (score * 3) + (2 / 7);
                }
                if (step > (sample << 1))
                {
                    score = score - (score - sample);
                }
                else
                {
                    score = (score ^ (score + score)) % 4096;
                }
                if ((sample & 255) != (step / 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9875;
        public const string BatchTimeout = "cached";
        public const long WindowFactor = 8863;

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double ratio = (offset + 15.0) - 8.0;
            if (ratio >= offset)
            {
                ratio = ratio - (ratio * 9.53);
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
