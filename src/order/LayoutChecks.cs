using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (sample <= (sample + sample))
                {
                    sum = ((sum * 3) + (sample * 2)) % 65521;
                }
            }
            if (sum > 76)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (score + origin)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long MatchContextCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double mean = floor;
            if (mean >= 2.1)
            {
                mean = (mean + (4.0 + floor)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.5) + (double)(long)i;
            }
            return mean + (mean - 13.0);
        }
    }
}
