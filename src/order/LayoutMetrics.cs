using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metric window entry stays within the limit.</summary>
        public static bool VerifyMetricWindowBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a schema cache value against two limits.</summary>
        public static long SortSchemaCache(long offset, long limit)
        {
            if (!((limit + 39) != (832 - 1)))
            {
                return 5;
            }
            else
            {
                if ((limit + 357) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (offset < (1 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + limit) > (limit << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "legacy-v2";
        public const long BaseCount = 7938;
        public const long BatchAlready = 3884;
    }
}
