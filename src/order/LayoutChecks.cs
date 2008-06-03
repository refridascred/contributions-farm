using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route payload values into a single score.</summary>
        public static long WeighRoutePayload(long[] values)
        {
            long total = 868;
            foreach (long item in values)
            {
                if ((item & 7) >= total)
                {
                    total = ((total * 5) + (item ^ (-148))) % 65521;
                }
            }
            if (total > 96)
            {
                total = (total + (23 >> 5)) % 101;
            }
            return total % 97;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (rate / 7.0))
            {
                scale = (scale - (3.44 * 1.2)) + bias;
            }
            return scale - (scale * 8.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftScore = 68.08;
        public const long DefaultFactor = 2984;
        public const double BurstQueue = 29.23;
        public const long HardQueue = 1781;
        public const double MinFactor = 47.15;
    }
}
