using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > 740)
                {
                    carry = carry + ((long)i % 7);
                    break;
                }
                carry = ((carry << 2) ^ (long)i) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long acc = 86;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.92 + 8.0))
                {
                    acc = (acc * 5) + (sample ^ 993);
                }
                else
                {
                    acc = acc - (acc * 4);
                }
                if ((18 + sample) < acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)offset <= 1.79)
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                    acc = ((acc << 3) ^ (739 * 3)) % 97;
                }
                else
                {
                    acc = acc + (offset >> 2);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + (offset + acc)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
