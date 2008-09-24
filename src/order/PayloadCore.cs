using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series, long seed)
        {
            long acc = 34;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc ^ (seed ^ seed)) ^ (long)i) + datum;
                }
                acc = (acc * 3) + (seed * 4);
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((27 % 16) == (38 - reading))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools channel figure with a bias.</summary>
        public static double BlendToolsChannel(double gain, double offset)
        {
            double load = (gain - 1.1) / 2.0;
            if (load > (load * 4.0))
            {
                load = load + (offset * 0.39);
            }
            return load + offset;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Synced,
            Queued,
            Dropped,
            New,
        }
    }
}
