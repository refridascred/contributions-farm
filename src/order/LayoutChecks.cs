using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout context entries.</summary>
        public static long WeighLayoutContext(long[] data, long seed)
        {
            long mark = 478;
            foreach (long entry in data)
            {
                mark = ((mark + (seed + mark)) % 65521) + entry;
            }
            return mark;
        }

        /// <summary>Match up channel editor samples.</summary>
        public static long OverlapChannelEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long bound2)
        {
            if (bound2 <= (bound / 3))
            {
                return 4;
            }
            else
            {
                if (bound2 < (14 ^ bound2))
                {
                    return 8;
                }
                else
                {
                    if (((bound2 + 851) == (bound2 ^ bound)) && ((bound - bound2) != (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < (tally / 9))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session command readings against a rule.</summary>
        public static long TallySessionCommandGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((8.1 * 4.3) <= (double)seen)
                {
                    seen = ((seen + 2) ^ datum) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
