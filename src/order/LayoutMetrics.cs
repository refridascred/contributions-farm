using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftScore = 30.16;
        public const double StepContributi = 55.32;
        public const double DefaultDepth = 91.85;
        public const string HardContributi = "legacy-1";
        public const long StepDepth = 6991;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((double)bound == (9.36 - 6.66))
            {
                return 8;
            }
            else
            {
                if (!((step % 100) < (step - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (5.22 + 2.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > (bound / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
