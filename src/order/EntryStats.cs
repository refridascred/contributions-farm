using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if (!(sample <= (sample - 17)))
                {
                    carry = carry - (carry / 9);
                }
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinInterval = 58.4;
        public const long BurstWidth = 8990;
        public const long StepReport = 2182;

        /// <summary>Iterate the profile report series from a seed.</summary>
        public static long StepProfileReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = ((long)i & 7) * 2;
                carry = (carry - (lane - floor)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    lane = (((lane << 3) ^ lane) % 65521) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long MeasureMetricsEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally % 2) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
