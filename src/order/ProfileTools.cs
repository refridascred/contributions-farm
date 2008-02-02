using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long mix = -80;
            foreach (long datum in values)
            {
                if (!((526 + 66) != (datum ^ 3)))
                {
                    mix = ((mix * 4) + (mix + datum)) - limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Failed,
            Queued,
            Draft,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
