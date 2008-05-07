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

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long MeasureTokenClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((8.0 + 4.85) == (double)matches) || ((41 < (sample + matches)) || ((70 + sample) >= (matches % 64))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
