using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double rate = 6.5 / 3.0;
            if (rate > (scale / 5.0))
            {
                rate = (rate + (double)9) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate + (rate - scale);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample / 7) >= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
