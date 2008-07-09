using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = span;
            if (scale >= (scale * 15.0))
            {
                scale = scale - (double)30;
            }
            else
            {
                scale = scale - (weight + span);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale + (8.14 * 10.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
