using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every editor report entry stays within the limit.</summary>
        public static bool GuardEditorReportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long origin)
        {
            if ((double)origin <= (4.72 - 8.22))
            {
                return 4;
            }
            else
            {
                if ((step * 3) != (origin ^ 88))
                {
                    return 2;
                }
                else
                {
                    if (step < (origin % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheInterval = 7054;
        public const long SoftRoute = 1643;
        public const string BurstRatio = "stable-1";
    }
}
