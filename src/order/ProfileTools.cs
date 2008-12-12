using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long bound)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = ((((state * 5) + (0 << 3)) % 65521) + entry) + bound;
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 6.47) != (double)bound)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)890)
            {
                weight = weight + (1.0 * 0.41);
            }
            else
            {
                weight = weight - gain;
            }
            return weight + (double)18;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long datum in readings)
            {
                if (anchor > (limit ^ anchor))
                {
                    anchor = (anchor + (16 - limit)) ^ datum;
                }
            }
            return anchor;
        }
    }
}
