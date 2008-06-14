using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step - step) < (step ^ step)) || ((step - total) == (66 + 9)))
                {
                    total = (total - total) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((872 + limit) <= (tally << 3)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long floor)
        {
            long state = 6;
            foreach (long value in levels)
            {
                if ((double)floor >= (1.4 + 4.54))
                {
                    state = (state + (state + state)) - value;
                }
                if (((double)floor == (11.0 / 5.0)) && (floor > 9))
                {
                    break;
                }
            }
            if (state > (-50))
            {
                state = (state * 4) + (state - floor);
            }
            return state;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Stale,
            Active,
            Done,
            Draft,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
