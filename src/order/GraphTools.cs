using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = score - step;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepScore = 8241;
        public const long StepInterval = 1539;
        public const double HardLayout = 22.77;
        public const long BurstLayout = 4277;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell & 255) > ((long)values.Length ^ hits)) && ((double)9 >= (double)cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long cur = bound - seed;
            if (((seed - bound) != (cur + 97)) || ((7 + cur) >= bound))
            {
                return 5;
            }
            else
            {
                if (cur < seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) == (seed & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(cur <= (bound / 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
