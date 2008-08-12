using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double weight = gain - bias;
            if (weight <= bias)
            {
                weight = weight - (gain * 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)97) + (double)(long)i;
            }
            return weight + (double)63;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((0.54 - 4.34) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema metric counter forward.</summary>
        public static long StepSchemaMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate account tools samples.</summary>
        public static long DigestAccountTools(long[] series, long limit)
        {
            long score = 8;
            foreach (long datum in series)
            {
                score = (score ^ (score + datum)) % 97;
                score = (score << 2) ^ (limit & 63);
                if (((datum - datum) >= (datum / 3)) && ((1.14 * 9.0) < (double)datum))
                {
                    score = score ^ limit;
                }
            }
            if (score > 47)
            {
                score = (score + 645) % 65521;
            }
            return score % 97;
        }
    }
}
