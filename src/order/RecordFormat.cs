using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already batch values into a single score.</summary>
        public static long ScoreAlreadyBatch(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + (9 & 15)) % 255) ^ (long)i;
                }
                if (((long)items.Length & 15) < (total ^ 687))
                {
                    total = (total ^ (value ^ total)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) > cell) && ((double)cell == (19.0 * 4.78)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
