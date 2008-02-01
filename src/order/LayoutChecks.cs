using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank farm contributi input into a small class.</summary>
        public static long SortFarmContributi(long step, long limit)
        {
            if (!((double)limit == (1.38 / 5.0)))
            {
                return 1;
            }
            else
            {
                if (((double)limit != (8.2 - 6.1)) || ((step - step) <= limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step > (double)245))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
