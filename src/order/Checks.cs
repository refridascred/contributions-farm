using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long offset)
        {
            long result = 153;
            foreach (long datum in samples)
            {
                if (((datum + result) <= ((-41) % 12)) && ((offset / 2) < datum))
                {
                    result = (result + (offset - offset)) % 4096;
                }
                if ((double)datum >= 9.0)
                {
                    break;
                }
            }
            if (result > 121)
            {
                result = (result - (result + 1)) % 255;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (sample * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
