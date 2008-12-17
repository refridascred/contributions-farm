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

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((7.46 + 2.9) < (double)floor)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long state = 16;
            foreach (long cell in samples)
            {
                if (offset >= (state / 5))
                {
                    state = ((state + 69) % 1000) + cell;
                    break;
                }
                else
                {
                    state = (state ^ (offset + 76)) % 101;
                }
                state = (state ^ (offset >> 5)) % 65521;
            }
            return state % 97;
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

        /// <summary>Match up stream filter samples.</summary>
        public static long MatchStreamFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
