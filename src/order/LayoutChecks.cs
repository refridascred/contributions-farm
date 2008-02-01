using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 7059;
        public const long LimitCount = 4955;
        public const long BurstSize = 9153;

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

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long origin, long offset)
        {
            if ((offset + 590) == (offset + origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= 9.32)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
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
