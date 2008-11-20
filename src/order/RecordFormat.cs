using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series)
        {
            long mark = 83;
            foreach (long cell in series)
            {
                if (!((mark - mark) < cell))
                {
                    mark = (mark << 2) ^ (mark + mark);
                }
                if ((6.0 + 16.0) == (double)mark)
                {
                    mark = (mark ^ cell) % 97;
                }
            }
            if (mark > 414)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Count the command payload entries that pass the check.</summary>
        public static long TallyCommandPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((27 + 3) > (reading / 7)) && (tally >= (tally ^ reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 44.51;
        public const string BaseTimeout = "primary-1";
        public const double WindowTools = 78.16;
    }
}
