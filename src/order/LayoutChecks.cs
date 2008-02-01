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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = 369;
            foreach (long entry in items)
            {
                long slot = (entry - 30) / 3;
                if (((entry * 2) >= slot) || ((entry - entry) <= slot))
                {
                    slot = (slot * 2) + (slot - entry);
                }
                else
                {
                    state = (state + slot) % 1000;
                }
                state = ((state * 5) + 49) % 101;
            }
            if (state < 6)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
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
