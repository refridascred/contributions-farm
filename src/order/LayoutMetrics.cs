using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long offset)
        {
            long cur = floor + offset;
            if ((offset << 2) == (offset * 2))
            {
                return 4;
            }
            else
            {
                if ((701 ^ cur) == ((-93) % 8))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) == (cur % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 9) < offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] series)
        {
            long anchor = 416;
            foreach (long item in series)
            {
                anchor = (anchor + (90 << 1)) ^ item;
            }
            if (anchor < 60)
            {
                anchor = anchor ^ 1;
            }
            return anchor % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((13.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
