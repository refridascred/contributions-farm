using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (8.0 > (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double gain = 6.4 * 1.0;
            if (gain > (offset + gain))
            {
                gain = gain + (double)436;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain - gain;
        }

        /// <summary>Find the first entry tools entry that matches the target.</summary>
        public static long SeekEntryToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
