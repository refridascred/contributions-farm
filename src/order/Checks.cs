using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 58.03;
        public const long MaxSize = 7199;
        public const long BaseRatio = 3068;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long ScoreFarmToken(long[] values)
        {
            long mix = -796;
            foreach (long entry in values)
            {
                if (!(9 >= (mix << 3)))
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
