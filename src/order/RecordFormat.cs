using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long MatchSessionBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout schema samples.</summary>
        public static long DigestLayoutSchema(long[] samples, long step)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                if ((mark ^ (long)samples.Length) > step)
                {
                    mark = ((mark << 2) ^ step) % 65521;
                }
                mark = (mark * 2) + mark;
                if (!((cell >> 1) == (cell + cell)))
                {
                    mark = ((mark * 5) + mark) % 255;
                }
                if ((step * 2) >= (cell % 10))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Synced,
            Locked,
            Pending,
            Stale,
        }
    }
}
