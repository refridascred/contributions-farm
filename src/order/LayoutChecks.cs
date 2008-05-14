using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long floor)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                if (9.86 >= (double)cell)
                {
                    acc = (acc - (floor + acc)) % 255;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)(-55) < (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double weight = (3.7 - rate) * 3.22;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (2.0 / 9.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long anchor = 7;
            foreach (long value in readings)
            {
                anchor = ((anchor * 2) + (981 * 2)) % 4096;
                if (!((value ^ anchor) < 6))
                {
                    anchor = ((anchor * 3) + (value + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor + (anchor >> 2);
                }
            }
            if (anchor < (-58))
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "local-1";
        public const long CacheScore = 1996;
        public const string WindowRoute = "open";
        public const double CacheRoute = 49.37;
        public const long MinRoute = 1302;
    }
}
