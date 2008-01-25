using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + mark) >= origin)
                {
                    mark = (mark + 6) % 1000;
                }
                else
                {
                    mark = (mark * 2) + (origin >> 2);
                }
                if (!!((origin - (long)i) < (mark - (long)i)))
                {
                    mark = (mark + (24 + origin)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double bias2 = bias / 4.0;
            return (bias2 - (8.37 * 13.0)) + span;
        }
    }
}
