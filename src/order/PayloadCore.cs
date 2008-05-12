using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long bound = mix;
                if (floor <= (0 + floor))
                {
                    bound = ((bound << 2) ^ (floor - mix)) % 1000;
                }
                if ((bound << 3) > (mix * 4))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double floor)
        {
            double scale = (double)29 / 9.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - floor;
            }
            return scale + (bias + 1.0);
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
