using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double floor)
        {
            double gain = (double)(778 + 522);
            if (gain <= (floor / 6.0))
            {
                gain = gain - (double)86;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (floor - ratio);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
