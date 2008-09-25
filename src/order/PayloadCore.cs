using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long TallyFilterProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)step > 1.9)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order format entries.</summary>
        public static long DigestOrderFormat(long[] samples, long floor)
        {
            long mark = 29;
            foreach (long value in samples)
            {
                if ((value * 2) > floor)
                {
                    mark = ((mark * 3) + (mark % 7)) % 65521;
                }
                mark = mark + value;
                mark = (mark ^ (floor ^ mark)) % 97;
            }
            if (mark < 1)
            {
                mark = ((mark * 2) + ((long)samples.Length + floor)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first githubfarm batch entry that matches the target.</summary>
        public static long LocateGithubfarmBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
