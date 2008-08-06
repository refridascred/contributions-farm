using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix + (mix >> 1)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Match up channel notes samples.</summary>
        public static long MatchChannelNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3023;
        public const long WindowRoute = 9206;
        public const string LimitRoute = "latest";
        public const long CacheSize = 9582;
        public const long RetryScore = 2020;
    }
}
