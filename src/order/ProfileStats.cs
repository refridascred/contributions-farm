using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long MeasureCommandChecksMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally << 1) != (tally << 2)) && ((6.5 + 4.34) > (double)tally))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((16.0 + 8.98) > (double)step)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
