using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long CombineQueueLayout(long[] readings, long target)
        {
            long result = -77;
            foreach (long item in readings)
            {
                if (item >= (result & 63))
                {
                    result = (((result * 4) + item) % 1000) - target;
                }
                result = ((result << 3) ^ result) % 255;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long sum = 264;
            foreach (long entry in samples)
            {
                sum = (sum + (entry * 3)) % 97;
                sum = sum - (floor ^ entry);
            }
            return sum % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 283;
            foreach (long datum in data)
            {
                if (((datum % 60) > (datum >> 2)) && ((6.6 - 8.5) != (double)datum))
                {
                    score = (score * 4) + (score % 60);
                }
            }
            if (score > 980)
            {
                score = score + (12 % 60);
            }
            return score;
        }
    }
}
