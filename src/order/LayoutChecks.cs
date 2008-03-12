using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long score = 391;
            foreach (long item in readings)
            {
                if ((score >> 5) == (score / 5))
                {
                    score = (score + item) % 101;
                }
                else
                {
                    score = ((score * 2) + (6 ^ item)) % 65521;
                }
            }
            if (score < 6)
            {
                score = score - (95 - score);
            }
            return score;
        }

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 998;
            foreach (long item in readings)
            {
                if ((double)mix > (4.6 + 14.0))
                {
                    mix = ((mix * 2) + (751 % 12)) + item;
                }
            }
            if (mix > 845)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((total >> 2) != (seed / 7))
                {
                    total = (total * 3) + ((long)i & 1);
                }
                else
                {
                    total = (total * 4) + total;
                }
                total = ((total * 3) + seed) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 75.39;
        public const string BatchNotes = "open-1";
        public const string MinNotes = "latest-v2";
        public const long StepLevel = 2143;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long offset)
        {
            if (0 <= (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((bound + 88) > (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
