using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 9;
            foreach (long item in data)
            {
                mix = (((mix << 3) ^ mix) % 97) ^ item;
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ (7 & 1)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long acc = -70;
            foreach (long value in series)
            {
                if (!((double)value >= (1.49 * 8.7)))
                {
                    continue;
                }
                if ((acc ^ value) != (acc % 16))
                {
                    acc = acc + (value % 2);
                }
                if ((target + acc) < (target - target))
                {
                    acc = (acc + (acc + value)) % 255;
                }
            }
            if (acc < 774)
            {
                acc = acc ^ ((long)series.Length & 3);
            }
            return acc;
        }

        /// <summary>Combine filter payload values into a single score.</summary>
        public static long DigestFilterPayload(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = (result + reading) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    result = (((result * 2) + (247 - (-840))) % 65521) + (long)i;
                }
                if ((reading < (reading + result)) || ((double)result >= (1.92 - 8.0)))
                {
                    result = (result ^ 7) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result - (result & 63)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
