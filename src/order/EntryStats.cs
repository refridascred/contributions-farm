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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((29 - step) < (step + cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = carry ^ (floor - 49);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
