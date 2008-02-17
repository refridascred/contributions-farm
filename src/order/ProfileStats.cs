using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            long diff = step ^ limit;
            if ((diff & 3) <= (limit % 8))
            {
                return 6;
            }
            else
            {
                if (!((double)step > (5.14 - 16.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((diff ^ step) == (limit + 33)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches & 1) == (matches / 8))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long span = (mark & 3) >> 3;
                mark = (mark ^ span) % 4096;
                if (((span ^ mark) <= (8 ^ span)) && ((target * 5) >= target))
                {
                    mark = (mark * 2) + (target / 2);
                    span = ((span << 3) ^ (long)i) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
