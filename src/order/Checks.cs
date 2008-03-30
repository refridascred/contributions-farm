using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long carry = 765;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading & 31)) % 4096;
                if ((reading >> 3) <= (reading + reading))
                {
                    carry = carry + reading;
                }
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((floor * 4) < floor2)
            {
                return 4;
            }
            else
            {
                if (floor >= (floor2 * 3))
                {
                    return 6;
                }
                else
                {
                    if (((20.0 - 7.3) >= (double)floor) && (floor <= (79 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
