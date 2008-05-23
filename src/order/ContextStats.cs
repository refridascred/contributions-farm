using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit checks filter readings against a rule.</summary>
        public static long TallyChecksFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!((reading + 278) <= (count - reading)))
                {
                    count = count + 1;
                }
            }
            return count;
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
