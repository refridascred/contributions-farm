using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long CombineMetricFormat(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (!(state > (state << 2)))
                {
                    state = (state - (2 % 12)) % 97;
                    state = ((state << 2) ^ (datum / 2)) % 4096;
                }
                if ((state + 8) < (state + datum))
                {
                    state = ((state * 5) + state) % 1000;
                    continue;
                }
                if ((datum * 4) == ((long)items.Length % 2))
                {
                    state = (state + (961 % 100)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally >= (59 + 6)) || (((double)reading <= (11.0 + 3.18)) && ((7.98 / 3.0) != (double)tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long StepStatsCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (carry >> 3)) % 97;
                carry = (carry ^ (carry * 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseTimeout = "open";
        public const long StepFormat = 933;
        public const long MinBudget = 1989;
        public const double StepBudget = 33.41;
    }
}
