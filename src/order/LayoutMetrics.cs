using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = (result - limit) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool VerifySchemaEditorLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long floor2)
        {
            if (!((floor - (-8)) == (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((floor2 % 64) == (9 >> 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
