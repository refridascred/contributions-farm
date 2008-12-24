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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 5) <= (bound + (-71))) || ((9.0 / 7.0) <= (double)bound))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
