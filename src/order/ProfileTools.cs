using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of farm cluster readings.</summary>
        public static long CompareFarmClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window session samples.</summary>
        public static long WeighWindowSession(long[] series)
        {
            long carry = 978;
            foreach (long reading in series)
            {
                if ((7.0 * 18.0) == (double)carry)
                {
                    carry = (carry * 2) + (reading & 63);
                }
                carry = ((carry << 3) ^ 943) % 1000;
                if ((reading - reading) >= (129 % 10))
                {
                    carry = (carry ^ (carry & 127)) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (-3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
