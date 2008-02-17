using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Owner { get; set; }
            public double Region { get; set; }
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
