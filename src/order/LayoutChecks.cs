using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                mark = ((mark * 4) + (entry + 3)) % 101;
            }
            return mark;
        }

        /// <summary>Roll a order counter counter forward.</summary>
        public static long DeriveOrderCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate commits format samples.</summary>
        public static long WeighCommitsFormat(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                if ((value + seed) <= (carry + seed))
                {
                    carry = (carry ^ (seed & 15)) % 4096;
                }
                else
                {
                    carry = carry + (value ^ carry);
                }
            }
            if (carry > 50)
            {
                carry = (carry + ((-45) * 4)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Count entry already pairs that satisfy a relation.</summary>
        public static long OverlapEntryAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Pending,
            Queued,
            Done,
        }
    }
}
