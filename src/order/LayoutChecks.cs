using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool ValidateGraphContextBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = offset;
            return (drift + (double)97) + gain;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = anchor ^ (long)samples.Length;
                if (((double)datum != (3.02 + 1.9)) || ((double)datum >= (6.3 / 9.0)))
                {
                    anchor = ((anchor << 2) ^ (datum + datum)) % 65521;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 5) + (anchor & 3);
            }
            return anchor;
        }
    }
}
