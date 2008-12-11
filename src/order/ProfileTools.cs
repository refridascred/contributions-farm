using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 6.47) != (double)bound)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 3.03;
        public const long LimitSchema = 8827;
        public const long SoftLevel = 1827;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(((12.0 / 4.0) <= (double)(long)i) || (((long)i - acc) == (limit << 3))))
                {
                    acc = acc - (long)i;
                    acc = (acc ^ (897 + acc)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
