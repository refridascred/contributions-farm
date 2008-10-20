using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double ratio = (double)(8 >> 2);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) + scale) - span;
            }
            return ratio - (double)17;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double drift = 12.0 / 4.0;
            if (drift < drift)
            {
                drift = (drift - scale) - offset;
            }
            return drift + scale;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Draft,
            Locked,
            Failed,
        }
    }
}
