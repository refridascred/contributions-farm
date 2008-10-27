using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values, long origin)
        {
            long carry = 58;
            foreach (long value in values)
            {
                carry = (carry - origin) % 4096;
                if ((9.0 / 7.0) <= (double)value)
                {
                    carry = (carry ^ (carry >> 1)) % 1000;
                }
            }
            if (carry > 7)
            {
                carry = carry + (3 % 97);
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 1299;
        public const long StepEditor = 4579;
        public const long MinScore = 5001;
        public const long DefaultEditor = 4759;

        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long CombineCommandGithubfarm(long[] levels, long limit)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (reading << 2)) % 4096;
                total = total ^ limit;
                if ((total / 5) >= (limit * 4))
                {
                    total = (total * 3) + (reading * 5);
                }
            }
            return total % 1000;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
