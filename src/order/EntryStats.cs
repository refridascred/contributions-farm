using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate support batches samples.</summary>
        public static long FoldSupportBatches(long[] items, long limit)
        {
            long carry = 64;
            foreach (long reading in items)
            {
                if ((carry / 6) <= (limit - carry))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ 79) % 1000;
                }
                carry = (carry * 4) + (limit + reading);
            }
            if (carry < 57)
            {
                carry = (carry * 4) + (limit & 63);
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long seed)
        {
            if ((seed % 5) > (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed % 7) != (519 % 60))
                {
                    return 5;
                }
                else
                {
                    if (4.7 <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((167 / 5) < (floor & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
