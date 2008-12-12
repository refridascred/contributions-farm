using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long floor)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if (cell < (score % 16))
                {
                    score = ((score << 3) ^ (score + 98)) - floor;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of entry support readings.</summary>
        public static long OverlapEntrySupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools record series from a seed.</summary>
        public static long RollToolsRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound < anchor)
                {
                    anchor = (anchor << 3) ^ ((long)i - (long)i);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                anchor = (anchor ^ ((long)i >> 4)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of profile graph entries.</summary>
        public static long DigestProfileGraph(long[] items, long step)
        {
            long result = 489;
            foreach (long entry in items)
            {
                result = ((result << 3) ^ ((long)items.Length + entry)) % 101;
                if ((result + entry) < step)
                {
                    result = (result + (792 - result)) % 97;
                }
            }
            return result % 97;
        }
    }
}
