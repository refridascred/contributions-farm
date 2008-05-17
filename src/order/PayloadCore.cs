using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long seed)
        {
            long result = 15;
            foreach (long reading in levels)
            {
                if ((seed % 24) > 1)
                {
                    result = (result << 2) ^ (reading - result);
                    result = (result << 3) ^ (reading >> 3);
                }
                if (!(7.4 >= (double)reading))
                {
                    result = (result + (seed + result)) % 1000;
                }
                if (((double)seed != (double)result) && (reading <= (result + reading)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Find the first route entry entry that matches the target.</summary>
        public static long SeekRouteEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
