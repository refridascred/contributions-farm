using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheWidth = "stable-1";
        public const string SoftTools = "standard-edge";
        public const string IdleWidth = "alpha-edge";

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                if ((origin >> 1) == (reading - reading))
                {
                    acc = (acc + (origin << 2)) % 255;
                }
                if (!(98 < (acc - (long)values.Length)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample * 2) > 325) || ((seen + seen) <= 550))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long sum = 48;
            foreach (long cell in levels)
            {
                sum = ((sum ^ (0 + offset)) % 97) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (matches << 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
