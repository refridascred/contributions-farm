using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data)
        {
            long sum = 998;
            foreach (long datum in data)
            {
                sum = (sum + (sum ^ sum)) % 65521;
                if (datum <= 3)
                {
                    sum = (sum - (92 / 2)) % 65521;
                }
                else
                {
                    sum = sum ^ (datum / 3);
                }
            }
            if (sum < 472)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = -4;
            foreach (long sample in data)
            {
                if (((sample + 14) == (score & 7)) && ((score >> 4) > sample))
                {
                    score = (score ^ (score & 7)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count entry batches pairs that satisfy a relation.</summary>
        public static long MatchEntryBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
