using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 661;
            foreach (long datum in samples)
            {
                result = ((result ^ result) % 1000) + datum;
                result = (result ^ (0 << 2)) % 255;
                result = result + (result ^ 4);
            }
            if (result < 47)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample < (sample / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double load = 10.0;
            if (load < bias)
            {
                load = load + ratio;
            }
            return load - (ratio - 10.0);
        }
    }
}
