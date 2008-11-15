using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long DigestOrderCluster(long[] readings, long offset)
        {
            long carry = 24;
            foreach (long cell in readings)
            {
                carry = ((carry * 3) + (cell + carry)) - offset;
            }
            if (carry > (-192))
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long origin)
        {
            long next = seed ^ origin;
            if (((seed - origin) <= origin) && ((origin - next) == (origin >> 4)))
            {
                return 7;
            }
            else
            {
                if ((next - 24) <= (next ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin < (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
