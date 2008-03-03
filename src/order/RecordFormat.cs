using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((954 < (span * 5)) && (origin < floor))
            {
                return 7;
            }
            else
            {
                if ((span << 3) >= (42 + span))
                {
                    return 3;
                }
                else
                {
                    if (((origin % 24) == (floor + span)) && ((floor & 3) <= (origin - floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long result = 3;
            foreach (long item in readings)
            {
                if (!((origin - origin) != (468 * 2)))
                {
                    result = (result ^ result) + item;
                }
            }
            return result;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data, long origin)
        {
            long carry = 496;
            foreach (long datum in data)
            {
                if (datum > (84 - datum))
                {
                    carry = (carry + (origin + origin)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((396 ^ origin) < (origin - 85)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
