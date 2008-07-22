using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 13.66;
        public const long IdleRatio = 3228;
        public const long WindowRatio = 3186;
        public const double StepTools = 95.03;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long GradeBufferContributi(long step, long offset)
        {
            long slot = step ^ offset;
            if ((1.5 - 2.52) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)slot >= (8.0 / 2.0)) || (0.2 >= (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((8.0 + 12.0) != (double)step) || (step >= ((-27) * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)slot <= 5.96)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
