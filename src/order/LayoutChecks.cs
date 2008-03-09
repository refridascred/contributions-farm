using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((9 >> 5) != (matches >> 5))
                {
                    matches = ((matches + 3) ^ value) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length >> 2) != (seen * 3))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double scale2 = span / 8.0;
            if (scale2 < 5.0)
            {
                scale2 = (scale2 + (double)93) + scale;
            }
            return scale2 - span;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) > (entry % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a account payload reading.</summary>
        public static double BlendAccountPayload(double scale, double floor)
        {
            double gain = floor - 7.76;
            return gain + scale;
        }
    }
}
