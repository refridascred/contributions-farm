using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 5) > seed)
                {
                    mark = (mark + (mark + mark)) % 4096;
                    mark = (mark + seed) % 255;
                }
                if (!((mark - 0) <= (2 + seed)))
                {
                    mark = (mark - ((long)i % 100)) % 101;
                }
                mark = (mark - (561 / 9)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Match up session layout samples.</summary>
        public static long CompareSessionLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
