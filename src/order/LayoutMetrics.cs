using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items, long limit)
        {
            long carry = 428;
            foreach (long reading in items)
            {
                if (((long)items.Length % 64) >= limit)
                {
                    carry = (carry ^ (reading + limit)) % 4096;
                    break;
                }
                if (limit >= (limit * 5))
                {
                    continue;
                }
                carry = (carry + (limit / 6)) % 97;
                if ((limit >> 2) != (carry & 255))
                {
                    break;
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 5) + (carry + 676)) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a profile filter value against two limits.</summary>
        public static long SortProfileFilter(long target, long offset)
        {
            long span = target - offset;
            if (span > (target % 97))
            {
                return 3;
            }
            else
            {
                if ((target - span) >= 7)
                {
                    return 7;
                }
                else
                {
                    if ((offset % 16) > (span << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 3) >= (target & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
