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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((value << 3) >= 859)
                {
                    score = (score * 5) + 62;
                }
            }
            return score % 4096;
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
