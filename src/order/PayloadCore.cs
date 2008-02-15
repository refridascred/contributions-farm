using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long target)
        {
            long score = 7;
            foreach (long sample in data)
            {
                if (((target / 3) >= (sample - score)) && ((sample & 63) == (target * 4)))
                {
                    score = (score + (score >> 5)) % 255;
                    continue;
                }
                if ((135 / 5) <= target)
                {
                    score = ((score << 2) ^ (target / 6)) % 97;
                    score = (score ^ (844 + target)) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample / 3);
                }
                score = ((score << 2) ^ (sample ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double weight = (double)(773 ^ 37);
            if (weight <= (double)1)
            {
                weight = (weight - weight) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (6.44 + scale)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Audit cluster metrics readings against a rule.</summary>
        public static long MeasureClusterMetricsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches > (datum % 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
