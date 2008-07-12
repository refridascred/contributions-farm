using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long origin)
        {
            if ((floor + 1) == (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if ((origin & 7) >= (58 % 100))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long delta = offset + step;
            if (delta >= (step * 5))
            {
                return 1;
            }
            else
            {
                if ((double)delta == (6.21 * 5.68))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) != (offset / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((148 + offset) > (delta & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((8 - 999) > (origin + sample)) || (((double)origin >= (7.11 + 18.0)) && ((double)seen != (double)sample)))
                {
                    seen = seen + 3;
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
