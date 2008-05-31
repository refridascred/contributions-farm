using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if (!(377 <= (reading + 93)))
                {
                    result = (result * 4) + (reading - result);
                    result = ((result * 5) + 343) % 255;
                }
                if (result >= (offset ^ offset))
                {
                    result = (result ^ 537) % 101;
                }
                else
                {
                    result = (result ^ (offset - 911)) % 65521;
                }
            }
            if (result < (-77))
            {
                result = (result << 2) ^ offset;
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many channel commits samples are out of range.</summary>
        public static long AuditChannelCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum != (double)99)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
