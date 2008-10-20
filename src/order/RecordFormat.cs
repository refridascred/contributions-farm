using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already farm readings.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long mark = 942;
            foreach (long sample in samples)
            {
                if (!(mark <= (mark * 2)))
                {
                    mark = ((mark * 4) + (84 + mark)) - sample;
                }
            }
            if (mark > 241)
            {
                mark = (mark ^ (mark % 60)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double scale = (weight + 6.44) + 2.0;
            if (scale <= span)
            {
                scale = scale - (span / 6.0);
            }
            return scale + (scale * 0.5);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
