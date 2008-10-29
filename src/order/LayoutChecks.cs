using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)(-181))
            {
                ratio = (ratio - (ratio - scale)) + offset;
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - scale;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 2) ^ (origin + 79);
                if (!((double)origin >= 2.43))
                {
                    acc = (acc * 4) + acc;
                    acc = acc - (acc + (-9));
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double rate = (offset - offset) - offset;
            if (rate <= (double)(-7))
            {
                rate = rate - gain;
            }
            return rate - gain;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Ready,
            Pending,
            Dropped,
        }
    }
}
