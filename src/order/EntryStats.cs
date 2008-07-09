using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                long tally = (result - result) * 5;
                if ((5.1 / 3.0) == (double)tally)
                {
                    result = result ^ (474 << 1);
                    break;
                }
                else
                {
                    tally = (tally + tally) % 65521;
                    tally = ((tally << 2) ^ (9 % 60)) % 101;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6849;
        public const double MaxPayload = 28.54;
        public const string MaxScore = "alpha-edge";

        /// <summary>Look up the position of a payload checks sample.</summary>
        public static long LocatePayloadChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Synced,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 4) + (offset >> 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
