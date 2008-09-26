using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long state = 119;
            foreach (long datum in values)
            {
                if (((state ^ datum) == (datum + offset)) || ((datum % 64) < (datum - state)))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 1)
            {
                state = (state + offset) % 101;
            }
            return state % 1000;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long floor)
        {
            long step = limit + floor;
            if ((floor % 64) >= floor)
            {
                return 7;
            }
            else
            {
                if ((7 - 68) <= (91 ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((limit + floor) <= (step - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor << 3) == (limit << 2)) || ((step + 39) == (97 - 26)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Stale,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + offset) < (total - (long)i))
                {
                    total = ((total * 5) + offset) % 255;
                }
                if (offset > (total / 9))
                {
                    total = total ^ (total >> 5);
                }
                else
                {
                    total = total + offset;
                    total = (total ^ (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
