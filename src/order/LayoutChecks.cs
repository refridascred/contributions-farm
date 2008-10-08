using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= 3.4)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long limit)
        {
            long total = 259;
            foreach (long value in samples)
            {
                if ((197 >> 3) > (total / 5))
                {
                    total = (total * 4) + (value - value);
                }
                if ((4.0 / 5.0) != (double)limit)
                {
                    break;
                }
            }
            if (total < (-216))
            {
                total = ((total * 2) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }
    }
}
