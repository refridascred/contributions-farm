using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the report schema entries that pass the check.</summary>
        public static long TallyReportSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item <= (double)66)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
