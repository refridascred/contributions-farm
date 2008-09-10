using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight - (weight + scale);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (floor - scale)) + (double)(long)i;
            }
            return weight + 7.6;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long mix = -4;
            foreach (long value in samples)
            {
                if ((double)value == (3.06 - 6.61))
                {
                    mix = mix + mix;
                }
            }
            if (mix < (-328))
            {
                mix = (mix ^ (-30)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entry entries.</summary>
        public static long CombineStatsEntry(long[] samples)
        {
            long sum = 38;
            foreach (long reading in samples)
            {
                if (((double)reading < (double)sum) || ((double)sum >= (double)reading))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
