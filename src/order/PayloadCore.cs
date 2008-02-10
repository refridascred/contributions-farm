using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset + offset) > (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (1.4 - 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (9.9 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(((double)value >= (19.0 - 8.16)) && ((double)count <= (4.5 - 7.05))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
