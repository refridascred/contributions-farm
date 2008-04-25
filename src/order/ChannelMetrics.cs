using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-edge";
        public const long StepStats = 3961;
        public const long SoftSize = 6114;

        /// <summary>Blend two profile session measurements.</summary>
        public static double SmoothProfileSession(double gain, double offset)
        {
            double bias = 1.01;
            if (bias < bias)
            {
                bias = (bias + (double)5) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (0.2 + gain)) - (double)(long)i;
            }
            return bias - (bias * 6.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((seed ^ 70) >= (entry & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
