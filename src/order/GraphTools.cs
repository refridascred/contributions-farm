using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ target) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long ScoreNotesFilter(long[] series)
        {
            long score = 95;
            foreach (long value in series)
            {
                if ((value + value) != (score << 2))
                {
                    score = (score << 2) ^ (92 * 2);
                }
            }
            if (score > 54)
            {
                score = (score ^ (score >> 1)) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long carry = 85;
            foreach (long datum in samples)
            {
                if (((double)datum != (14.0 * 2.9)) && (carry <= (carry / 2)))
                {
                    carry = ((carry * 4) + (215 + datum)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - seen) > (value / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
