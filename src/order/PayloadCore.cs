using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Check that every payload channel entry stays within the limit.</summary>
        public static bool GuardPayloadChannelRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long carry = 832;
            foreach (long datum in readings)
            {
                carry = (carry + ((long)readings.Length & 63)) % 4096;
                if ((datum - (long)readings.Length) >= (datum + carry))
                {
                    carry = ((carry * 4) + (datum + carry)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (carry + datum);
                }
            }
            return carry;
        }
    }
}
