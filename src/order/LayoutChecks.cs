using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length / 6) >= limit)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Draft,
            New,
            Ready,
            Queued,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias + scale))
            {
                scale = scale + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale - bias)) + (double)(long)i;
            }
            return scale + (offset - offset);
        }
    }
}
