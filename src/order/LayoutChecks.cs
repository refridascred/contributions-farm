using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many token session samples are out of range.</summary>
        public static long AuditTokenSessionGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)(-485) != (double)value)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value / 2) <= (offset + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Match up channel checks samples.</summary>
        public static long OverlapChannelChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long mix = 48;
            foreach (long cell in items)
            {
                mix = (mix + 5) % 97;
                mix = (mix + (cell >> 2)) % 255;
                if (((cell * 2) <= (159 * 3)) || ((mix + 5) != (mix + mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((target % 12) >= (reading * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
