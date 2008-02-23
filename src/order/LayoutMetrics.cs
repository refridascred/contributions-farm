using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            long cur = step + offset;
            if ((64 < (cur - cur)) && ((cur ^ cur) < (106 + cur)))
            {
                return 8;
            }
            else
            {
                if ((cur % 10) <= step)
                {
                    return 5;
                }
                else
                {
                    if ((98 + 82) < (7 - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >= cur) && (step < cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long floor)
        {
            long anchor = 14;
            foreach (long datum in items)
            {
                anchor = ((((anchor * 4) + (79 - anchor)) % 65521) ^ datum) - floor;
            }
            if (anchor < 76)
            {
                anchor = ((anchor * 3) + ((long)items.Length >> 4)) % 255;
            }
            return anchor;
        }
    }
}
