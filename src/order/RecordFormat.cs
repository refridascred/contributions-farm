using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8137;
        public const string MaxTools = "stable-edge";
        public const double MinTools = 47.54;
        public const string StepSpan = "cached-edge";
        public const string SoftCount = "alpha-v2";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long seed)
        {
            if ((floor << 2) <= seed)
            {
                return 2;
            }
            else
            {
                if (((-400) + floor) >= (seed / 7))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 1) > (6 / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long total = 324;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (((total * 2) + item) % 4096) ^ (long)i;
                }
                if (((step - step) != (total + item)) && ((16.0 - 19.0) <= (double)item))
                {
                    total = total + (step + item);
                }
            }
            if (total > 7)
            {
                total = ((total * 5) + (step * 5)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long seed)
        {
            long score = 50;
            foreach (long cell in samples)
            {
                score = (score * 3) + (seed - score);
                if ((score << 1) == (cell / 9))
                {
                    score = ((score * 3) + seed) % 65521;
                }
            }
            return score;
        }
    }
}
