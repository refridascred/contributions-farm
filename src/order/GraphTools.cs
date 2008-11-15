using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of command profile readings.</summary>
        public static long TotalCommandProfile(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                acc = (acc * 2) + (entry * 3);
            }
            if (acc < 394)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc % 65521;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long bound)
        {
            long result = 33;
            foreach (long cell in data)
            {
                result = ((result + (bound + bound)) % 97) ^ cell;
            }
            if (result > 4)
            {
                result = (result + result) % 1000;
            }
            return result % 1000;
        }
    }
}
