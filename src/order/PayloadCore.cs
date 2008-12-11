using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long offset)
        {
            long delta = bound ^ offset;
            if (!((bound & 31) != (delta << 3)))
            {
                return 4;
            }
            else
            {
                if ((double)delta < (2.0 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if (offset < ((-74) ^ delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset <= (offset + offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count order stream pairs that satisfy a relation.</summary>
        public static long MatchOrderStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
