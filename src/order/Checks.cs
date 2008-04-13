using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((624 - item) <= (seen + seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double load = (double)46 * 19.0;
            if (load >= (double)9)
            {
                load = load + (weight / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length << 3) <= (hits & 63))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + floor) <= score)
                {
                    score = (score ^ 2) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
