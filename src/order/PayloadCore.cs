using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long mix = -260;
            foreach (long value in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (offset - mix)) % 97) ^ (long)i;
                    mix = ((mix << 3) ^ ((long)readings.Length + (long)readings.Length)) % 101;
                }
                if ((value ^ value) <= value)
                {
                    mix = (mix * 5) + ((-81) + mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double ratio = gain - floor;
            if (ratio <= gain)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)167;
            }
            return ratio + (double)4;
        }
    }
}
