using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - sample) > (seen & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double rate = (double)(126 & 3);
            if (rate >= (rate / 4.0))
            {
                rate = (rate + offset) + weight;
            }
            else
            {
                rate = rate + 1.1;
            }
            return rate + rate;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 2) <= (matches - value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
