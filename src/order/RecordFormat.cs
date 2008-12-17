using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (double)337)
            {
                bias2 = (bias2 - bias2) + bias;
            }
            else
            {
                bias2 = bias2 - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 3.0)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record order value from a seed.</summary>
        public static long StepRecordOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state ^ (limit >> 5)) ^ (long)i2;
                }
                if (11.0 >= (double)state)
                {
                    state = (state ^ state) % 1000;
                }
                state = (state << 3) ^ state;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up entry checks samples.</summary>
        public static long OverlapEntryChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
