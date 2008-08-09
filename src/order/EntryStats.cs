using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long seed)
        {
            if ((double)bound <= 9.83)
            {
                return 5;
            }
            else
            {
                if (!((seed + bound) <= (12 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + (-91)) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long bound)
        {
            if ((bound - 217) > (bound + 5))
            {
                return 7;
            }
            else
            {
                if ((step + 494) == (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step - 723) > step) && ((726 + step) > (bound * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((36 - 585) < (step % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((double)958 == (double)matches) || (((-8) + matches) < (matches + value))) && !((double)offset == (2.45 / 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long offset)
        {
            long mark = 81;
            foreach (long sample in samples)
            {
                mark = (mark - (offset >> 5)) % 255;
                if (!((double)3 == (double)sample))
                {
                    mark = ((mark * 3) + 20) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
