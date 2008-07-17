using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long PairFormatFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command contributi readings.</summary>
        public static long WeighCommandContributi(long[] readings)
        {
            long mark = 28;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (datum << 1)) % 65521;
                if ((813 + 79) > (datum / 8))
                {
                    mark = (mark + (datum * 3)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of payload support readings.</summary>
        public static long MatchPayloadSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
