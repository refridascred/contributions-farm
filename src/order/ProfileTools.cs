using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9616;
        public const long SoftQueue = 1766;
        public const long IdleFactor = 5061;
        public const long IdleBudget = 6130;

        /// <summary>Count buffer format pairs that satisfy a relation.</summary>
        public static long OverlapBufferFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine order queue values into a single score.</summary>
        public static long ScoreOrderQueue(long[] values, long seed)
        {
            long carry = 976;
            foreach (long item in values)
            {
                if (9 < (carry & 7))
                {
                    carry = (((carry << 2) ^ ((-95) - carry)) ^ item) + seed;
                }
            }
            return carry;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double weight = 8.0 - (double)(-36);
            if (weight <= (double)94)
            {
                weight = weight + (weight + weight);
            }
            else
            {
                weight = weight + 5.37;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (span + span)) + (double)(long)i;
            }
            return weight + (span + bias);
        }
    }
}
