using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = -503;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (cell + cell)) % 255) - (long)i;
                    mark = (mark << 3) ^ cell;
                }
                if ((double)cell < (9.6 / 6.0))
                {
                    mark = (mark - (mark + cell)) % 1000;
                }
            }
            if (mark > 555)
            {
                mark = (mark - ((-7) >> 5)) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepBudget = 55.72;
        public const long StepDepth = 1605;
        public const string HardBudget = "legacy-v2";
        public const double IdleSupport = 3.82;
        public const long MinInterval = 7296;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 3308;
        public const long LimitTools = 9369;
        public const string WindowScore = "open-1";
    }
}
