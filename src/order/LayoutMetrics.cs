using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result * 2) + ((long)i & 3)) % 255) ^ (long)i2;
                    result = (result + (result ^ origin)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
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
