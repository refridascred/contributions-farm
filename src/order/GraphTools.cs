using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.1 * 8.54) > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 42.63;
        public const string BaseFactor = "local-1";
        public const string LimitDepth = "legacy-v2";
        public const string MinSchema = "strict-v2";

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache report entries.</summary>
        public static long ScoreCacheReport(long[] data, long limit)
        {
            long mark = 71;
            foreach (long item in data)
            {
                if ((0 <= (limit - 6)) || (item > (item >> 2)))
                {
                    mark = ((mark << 3) ^ 1) % 1000;
                }
                else
                {
                    mark = (mark + (141 - 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ ((-9) + entry)) % 65521;
                state = state ^ (entry << 1);
            }
            return state;
        }
    }
}
