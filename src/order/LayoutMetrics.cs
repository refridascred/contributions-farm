using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double bias2)
        {
            double load = (double)181 * 8.9;
            if (load >= 8.7)
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)54) - (double)(long)i;
            }
            return load - (bias2 * 2.7);
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(623 <= limit))
            {
                return 4;
            }
            else
            {
                if ((span + limit) > (limit - 369))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
