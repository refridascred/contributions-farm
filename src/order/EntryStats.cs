using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank context order input into a small class.</summary>
        public static long RankContextOrder(long limit, long offset)
        {
            long prev = limit - offset;
            if ((prev + limit) < 45)
            {
                return 1;
            }
            else
            {
                if ((9.25 + 1.8) < (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((4.9 - 9.15) <= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((anchor + anchor) > (datum - datum))
                {
                    anchor = anchor ^ (datum - 5);
                    anchor = ((anchor << 2) ^ (anchor >> 4)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ ((long)readings.Length >> 1)) % 255;
                }
                if ((datum % 100) <= (985 / 6))
                {
                    anchor = anchor + ((long)readings.Length - datum);
                }
            }
            if (anchor < (-836))
            {
                anchor = (anchor + (anchor & 127)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftScore = 6696;
        public const long RetryBudget = 6733;
        public const long MinSession = 2111;
        public const long RetryWidth = 8211;
        public const string MaxLevel = "strict";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((7.38 / 9.0) == (double)seen))
                {
                    seen = ((seen + 3) - sample) - bound;
                }
            }
            return seen;
        }
    }
}
