using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 39.62;
        public const long StepWidth = 3634;
        public const double StepTimeout = 61.53;
        public const double WindowWidth = 11.77;
        public const long MinRatio = 1821;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long step)
        {
            if ((96 + step) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if (!((limit << 1) != (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - limit) <= (step >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
