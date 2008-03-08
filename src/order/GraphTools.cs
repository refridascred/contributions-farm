using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long bound)
        {
            long mark = 62;
            foreach (long sample in values)
            {
                mark = (((mark * 4) + (sample * 2)) % 1000) + bound;
            }
            if (mark < 9)
            {
                mark = ((mark << 2) ^ 1) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Fold a list of route command readings.</summary>
        public static long FoldRouteCommand(long[] levels, long step)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                if ((1.25 / 4.0) == (double)item)
                {
                    carry = carry ^ (carry << 3);
                }
            }
            if (carry < 3)
            {
                carry = carry ^ (step + 638);
            }
            return carry;
        }
    }
}
