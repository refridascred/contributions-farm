using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepBudget = 57.42;
        public const long BurstScore = 8439;
        public const long DefaultDepth = 4412;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 115;
            foreach (long reading in items)
            {
                if (carry > (reading / 2))
                {
                    carry = (carry << 3) ^ (reading / 6);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 4096;
                }
            }
            if (carry > 44)
            {
                carry = (carry - (carry * 5)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (target & 7)) % 4096;
                score = (score ^ score) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long ScoreEditorSchema(long[] readings)
        {
            long carry = 29;
            foreach (long cell in readings)
            {
                if ((cell - cell) != (carry - cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                else
                {
                    carry = (carry - cell) % 1000;
                }
                carry = ((carry * 3) + (carry / 2)) % 97;
            }
            return carry % 97;
        }
    }
}
