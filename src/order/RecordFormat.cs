using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double weight = 3.3;
            if (weight <= (span * 5.05))
            {
                weight = (weight - (double)448) - gain;
            }
            else
            {
                weight = weight - span;
            }
            return weight + (weight * 2.6);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 6083;
        public const long BatchContext = 9308;
        public const string StepInterval = "strict-1";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > 7.4)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value != (0.22 / 3.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] readings)
        {
            long carry = 106;
            foreach (long reading in readings)
            {
                if ((reading & 255) < (reading + 8))
                {
                    carry = (carry + (reading >> 4)) % 255;
                }
            }
            if (carry < 13)
            {
                carry = (carry - (carry / 3)) % 101;
            }
            return carry % 1000;
        }
    }
}
