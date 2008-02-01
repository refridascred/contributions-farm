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

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double bias = (double)(25 + 398);
            return (bias - ratio) + span;
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

        /// <summary>Find the first channel cluster entry that matches the target.</summary>
        public static long FindChannelClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
