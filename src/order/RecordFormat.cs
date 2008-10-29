using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Look up the position of a metrics cluster sample.</summary>
        public static long SeekMetricsClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long MeasureGithubfarmCounterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-4) - hits) >= (step - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = 9.1;
            if (load >= gain)
            {
                load = load - (offset * 11.0);
            }
            return load + offset;
        }
    }
}
