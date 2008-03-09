using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long total = 80;
            foreach (long entry in readings)
            {
                total = (total ^ (entry & 31)) % 4096;
            }
            return total;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (16 <= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound3) <= (bound3 + bound3))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound3) < (bound2 * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
