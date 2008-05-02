using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long CombineCommitsSchema(long[] values)
        {
            long mark = 451;
            foreach (long item in values)
            {
                mark = ((mark << 2) ^ (item - 0)) % 65521;
                if ((item + mark) < (mark + mark))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                if ((item >> 5) <= (item << 1))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
