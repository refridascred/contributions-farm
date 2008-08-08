using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (offset <= (item + offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Stale,
            New,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 293;
            foreach (long sample in values)
            {
                if (carry < (carry & 15))
                {
                    break;
                }
                if ((sample / 8) >= (sample / 7))
                {
                    carry = (carry << 2) ^ (long)values.Length;
                }
            }
            if (carry > 6)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry;
        }
    }
}
