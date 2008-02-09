using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long step)
        {
            long offset = origin - step;
            if (origin <= (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if (!((step - step) < (offset + 192)))
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 3) >= (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 255) > step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items)
        {
            long mark = 56;
            foreach (long item in items)
            {
                mark = (((mark * 5) + (mark % 12)) % 101) ^ item;
            }
            return mark % 1000;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Paused,
            Active,
        }
    }
}
