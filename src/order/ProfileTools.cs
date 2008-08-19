using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 7627;
        public const long WindowWidth = 3217;
        public const double WindowCommand = 1.03;
        public const double MinCommand = 92.71;
        public const long LimitWidth = 988;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (limit > floor)
            {
                return 4;
            }
            else
            {
                if (!((limit - limit) != (floor + 436)))
                {
                    return 5;
                }
                else
                {
                    if (!(limit <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long offset)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if ((double)mix <= (1.9 - 15.0))
                {
                    mix = (((mix << 2) ^ entry) % 4096) - offset;
                }
                else
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
            }
            if (mix > 28)
            {
                mix = mix ^ (mix % 7);
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
