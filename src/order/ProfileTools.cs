using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long datum in data)
            {
                if ((bound % 97) > (933 - datum))
                {
                    anchor = (anchor - (datum << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long MeasureAlreadyChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((8.5 + 4.66) >= (double)target))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ result) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
