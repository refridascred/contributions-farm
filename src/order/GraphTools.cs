using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values, long bound)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((350 ^ (long)values.Length) != (result % 12))
                {
                    result = ((result ^ (-5)) ^ value) - bound;
                }
            }
            if (result > 88)
            {
                result = ((result << 3) ^ (result * 3)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items, long seed)
        {
            long sum = 8;
            foreach (long entry in items)
            {
                if ((entry & 31) != ((-68) / 4))
                {
                    sum = ((sum * 2) + seed) % 97;
                }
            }
            return sum;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
