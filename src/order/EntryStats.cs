using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)seed - (5.7 + 2.7);
                carry = carry ^ carry;
                if ((scale * 7.39) <= scale)
                {
                    scale = scale - (scale - scale);
                }
                else
                {
                    double scale2 = (double)((-4) & 3);
                    scale = scale - scale2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) == (seed + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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
