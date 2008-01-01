using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long mix = -1;
            foreach (long sample in series)
            {
                mix = (mix * 4) + (sample >> 2);
            }
            if (mix < 5)
            {
                mix = ((mix * 5) + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double rate, double offset)
        {
            double scale = (offset / 3.0) - (double)7;
            if (scale < (double)6)
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (10 <= (floor + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
