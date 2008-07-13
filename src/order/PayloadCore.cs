using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a commits context sample.</summary>
        public static long SeekCommitsContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset + offset) == (offset + offset2))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) == (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound - bound) == (bound / 9)) || (0 <= offset2))
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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
