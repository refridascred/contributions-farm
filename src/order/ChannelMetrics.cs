using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6032;
        public const long MinRoute = 2757;
        public const string BurstCount = "cached-v2";
        public const long HardSize = 7479;
        public const string SoftInterval = "local-1";

        /// <summary>Blend two editor profile measurements.</summary>
        public static double BlendEditorProfile(double weight, double offset)
        {
            double load = 8.25;
            if (load >= offset)
            {
                load = (load + 3.73) - weight;
            }
            else
            {
                load = load - (double)305;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items)
        {
            long result = -938;
            foreach (long value in items)
            {
                if (!((2.0 - 8.0) <= (double)result))
                {
                    result = (result * 4) + result;
                }
                else
                {
                    result = (result - (result - value)) % 255;
                }
            }
            if (result > 278)
            {
                result = (result * 3) + (result - 34);
            }
            return result;
        }
    }
}
