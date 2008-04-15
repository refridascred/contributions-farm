using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)928) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 1.0) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((87 + seen) > (919 - 5)) || ((value >> 5) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Queued,
        }
    }
}
