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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
