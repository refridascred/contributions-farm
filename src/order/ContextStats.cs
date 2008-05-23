using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Locked,
            Failed,
            Ready,
            New,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long seed)
        {
            long acc = 93;
            foreach (long entry in data)
            {
                if (((double)acc > (4.6 * 7.3)) || ((seed + entry) <= (acc ^ 629)))
                {
                    acc = (acc * 2) + seed;
                }
                else
                {
                    acc = ((acc << 2) ^ (85 - 92)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
