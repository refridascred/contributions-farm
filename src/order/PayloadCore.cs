using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool GuardAlreadySchemaLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long total = 9;
            foreach (long value in levels)
            {
                if ((double)total == (3.59 - 2.0))
                {
                    total = (total + value) % 4096;
                }
                else
                {
                    total = (total * 5) + (562 & 15);
                }
            }
            if (total < 8)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (sum / 3)) % 255;
                if ((reading % 5) > (reading << 1))
                {
                    sum = (sum ^ (step + 440)) % 255;
                }
                else
                {
                    sum = (sum ^ 13) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Failed,
            Retry,
        }
    }
}
