using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long DefaultBudget = 1703;
        public const long SoftOrder = 2514;
        public const string IdleRatio = "open-edge";

        /// <summary>Check that every stream filter entry stays within the limit.</summary>
        public static bool VerifyStreamFilterRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long CompareWindowFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double BlendFormatWindow(double ratio, double bias)
        {
            double ratio2 = 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (((ratio2 + ratio2) - (double)(long)i) - ratio) + bias;
            }
            return ratio2 + 8.0;
        }
    }
}
