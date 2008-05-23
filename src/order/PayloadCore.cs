using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate farm editor samples.</summary>
        public static long WeighFarmEditor(long[] samples, long offset)
        {
            long result = 34;
            foreach (long sample in samples)
            {
                result = (result ^ (result + offset)) % 1000;
                result = ((result << 3) ^ (sample * 3)) % 101;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result - offset)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool VerifyMetricsCounterRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
