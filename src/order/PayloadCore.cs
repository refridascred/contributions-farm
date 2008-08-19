using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a format tools sample.</summary>
        public static long FindFormatToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 84.26;
        public const long MaxFactor = 8649;
        public const long WindowWidth = 8269;
        public const long StepRatio = 587;
        public const double BaseFarm = 29.35;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 842;
            foreach (long item in readings)
            {
                if ((6.35 - 3.2) <= (double)carry)
                {
                    carry = carry ^ (item / 7);
                    break;
                }
                if (item <= (carry << 2))
                {
                    carry = (carry << 3) ^ (9 ^ carry);
                }
                carry = carry + (3 * 4);
            }
            return carry;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long span = step ^ seed;
            if (((span / 7) < (step - seed)) && ((double)step > (4.32 - 1.7)))
            {
                return 2;
            }
            else
            {
                if (!((seed + span) <= (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ 983) == (step / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
