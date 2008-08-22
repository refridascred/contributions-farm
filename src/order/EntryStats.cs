using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((double)bound < (3.19 * 1.2))
                {
                    acc = acc ^ (bound * 5);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data)
        {
            long carry = 280;
            foreach (long datum in data)
            {
                if (carry < datum)
                {
                    carry = (carry - ((long)data.Length ^ datum)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum < (420 + datum))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Done,
            Queued,
            Active,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - ((long)i + anchor);
                anchor = ((anchor * 4) + limit) % 97;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
