using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                if (((result - result) == (entry & 127)) && ((result / 9) < entry))
                {
                    result = ((result << 3) ^ (entry + entry)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (628 >> 1)) % 4096;
                }
                if ((465 + entry) == (result - entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long acc = 582;
            foreach (long reading in readings)
            {
                if (((reading + reading) < (acc + acc)) && ((acc << 1) >= acc))
                {
                    acc = (acc ^ (reading >> 5)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = acc + (acc & 1);
            }
            return acc;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
