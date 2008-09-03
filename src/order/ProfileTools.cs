using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every order record entry stays within the limit.</summary>
        public static bool CheckOrderRecordLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((floor % 3) == (value * 3)) || ((8.22 / 2.0) == (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a support queue figure with a bias.</summary>
        public static double BlendSupportQueue(double gain, double offset)
        {
            double bias = (double)((-941) - 32);
            if (bias > bias)
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + (gain * 2.9);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias + 15.0;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Match up contributi order samples.</summary>
        public static long OverlapContributiOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
