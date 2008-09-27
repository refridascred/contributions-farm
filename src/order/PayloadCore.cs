using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a window stream counter forward.</summary>
        public static long StepWindowStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >> 4) <= (sum + sum))
                {
                    sum = ((sum * 5) + (offset ^ (long)i)) % 101;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            if ((double)floor > 4.0)
            {
                return 5;
            }
            else
            {
                if ((target + 3) >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
