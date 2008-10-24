using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool ValidateTokenQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster order samples.</summary>
        public static long TotalClusterOrder(long[] data, long seed)
        {
            long mix = 49;
            foreach (long datum in data)
            {
                if (seed < (5 - mix))
                {
                    mix = (mix ^ datum) % 1000;
                }
                if (((mix << 2) <= (seed ^ seed)) && ((69 & 63) == (datum >> 1)))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (seed % 3);
            }
            return mix % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 8820;
        public const long HardWidth = 7970;
        public const long StepWindow = 4915;
        public const string MinWindow = "staging";

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                long edge = seed << 3;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (906 + 2)) % 97) ^ (long)i2;
                }
                if (((long)i ^ seed) >= (edge + seed))
                {
                    edge = (edge * 3) + (edge * 2);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long diff = ((long)i + (long)i) >> 5;
                if (!(carry > (diff * 4)))
                {
                    carry = (carry + (diff + (long)i)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
