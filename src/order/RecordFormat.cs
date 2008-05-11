using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long floor)
        {
            long score = 528;
            foreach (long reading in samples)
            {
                score = score + reading;
                if ((7.55 + 9.02) != (double)floor)
                {
                    score = score + floor;
                }
            }
            if (score > (-6))
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Ready,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double span)
        {
            double ratio = span / 5.0;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio / 7.0);
            }
            else
            {
                ratio = ratio - (weight - 8.5);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 1.4) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "latest";
        public const long IdleRoute = 7529;
        public const long RetryRoute = 8373;
        public const long WindowBudget = 4894;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((1 + datum) <= (seen << 3)) || ((double)(long)data.Length < (double)seen)) && (seen >= ((long)data.Length + datum)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
