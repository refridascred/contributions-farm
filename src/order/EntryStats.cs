using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up schema cluster samples.</summary>
        public static long OverlapSchemaClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Fold a list of already tools readings.</summary>
        public static long TallyAlreadyTools(long[] values, long floor)
        {
            long score = 73;
            foreach (long sample in values)
            {
                score = ((score ^ 19) + sample) - floor;
                score = (score ^ (score * 2)) % 97;
                score = (score + score) % 65521;
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
