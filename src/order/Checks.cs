using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool VerifySupportNotesLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if (origin > (offset + 4))
            {
                return 5;
            }
            else
            {
                if ((5.8 * 5.82) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches * 2) <= datum) || ((7.0 - 3.0) > (double)datum))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long floor)
        {
            long state = 16;
            foreach (long sample in data)
            {
                state = ((state ^ ((-84) - floor)) % 97) + sample;
                if (floor > (long)data.Length)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
