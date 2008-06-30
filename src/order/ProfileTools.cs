using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 4096) ^ (long)i;
                }
                anchor = (anchor ^ (item + item)) % 4096;
                anchor = (anchor - ((long)data.Length ^ item)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + hits) != (622 - 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long sum = 9;
            foreach (long reading in series)
            {
                sum = (sum - 45) % 255;
                if ((reading % 12) >= (reading - sum))
                {
                    sum = ((sum * 3) + (reading << 3)) % 1000;
                }
                if ((7.07 / 6.0) < (double)reading)
                {
                    sum = ((sum << 2) ^ (reading % 12)) % 97;
                }
                else
                {
                    sum = (sum * 5) + (sum >> 5);
                }
            }
            return sum;
        }
    }
}
