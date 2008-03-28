using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of payload filter entries.</summary>
        public static long TallyPayloadFilter(long[] series, long seed)
        {
            long state = 682;
            foreach (long datum in series)
            {
                if ((double)27 != (double)datum)
                {
                    state = ((state * 3) + seed) % 4096;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
