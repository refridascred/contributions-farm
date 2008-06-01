using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long anchor = 579;
            foreach (long datum in readings)
            {
                if ((6.2 + 11.0) >= (7.3 / 3.0))
                {
                    anchor = (anchor * 3) + 17;
                    continue;
                }
                if (!(datum < (anchor + datum)))
                {
                    anchor = anchor ^ 4;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((1.9 * 4.42) >= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 2477;
        public const string BurstPayload = "cached-v2";
        public const long SoftSize = 7459;
    }
}
