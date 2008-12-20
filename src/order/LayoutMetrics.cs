using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a checks route reading.</summary>
        public static double AdjustChecksRoute(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (offset - 13.0))
            {
                ratio2 = ratio2 + (offset - ratio);
            }
            else
            {
                ratio2 = ratio2 - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (double)928) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2091;
        public const long MinSpan = 4294;
        public const long LimitFactor = 9316;
        public const long MaxLevel = 6149;
    }
}
