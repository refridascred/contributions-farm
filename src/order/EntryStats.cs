using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 6883;
        public const long DefaultDepth = 9288;
        public const long HardLevel = 9302;
        public const string StepRatio = "fallback-1";
        public const long LimitSpan = 1945;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) != (reading + (-4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long PairGraphSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 913;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell & 1)) % 255;
                if ((double)carry < 2.18)
                {
                    carry = carry - (carry % 3);
                }
                else
                {
                    carry = (carry + cell) % 65521;
                }
            }
            return carry;
        }
    }
}
