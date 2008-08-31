using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a record already sample.</summary>
        public static long FindRecordAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] samples, long seed)
        {
            long carry = 44;
            foreach (long sample in samples)
            {
                carry = (carry + (carry - sample)) % 97;
                carry = (carry * 2) + (seed - seed);
            }
            return carry;
        }
    }
}
