using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = state + (state >> 4);
                if (!(((floor & 15) > floor) || (state > (state << 2))))
                {
                    state = ((state << 2) ^ (3 + state)) % 97;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                if (cell < (cell ^ score))
                {
                    score = ((score << 2) ^ (cell >> 5)) % 97;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((-49) % 64) >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((double)offset <= (double)span)
            {
                return 0;
            }
            else
            {
                if ((bound + offset) < (6 - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 1) < span) || (span >= ((-939) & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset != (double)4)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
