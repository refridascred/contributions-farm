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

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8936;
        public const long BaseStream = 9792;
        public const long WindowInterval = 4363;
        public const long BurstScore = 9414;

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
