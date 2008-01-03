using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + ((long)i - carry)) % 65521) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long bound)
        {
            long carry = 79;
            foreach (long datum in readings)
            {
                carry = (carry << 3) ^ (bound >> 5);
                if ((carry - datum) != (datum + carry))
                {
                    carry = carry - ((-302) % 100);
                }
            }
            if (carry > 172)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double drift = bias;
            if (drift < 16.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - 0.5);
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
