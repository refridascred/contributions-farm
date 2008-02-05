using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (6.9 - 0.48))
                {
                    total = (total + (2 - (-29))) % 65521;
                }
                if ((double)(long)values.Length == (double)value)
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 3) ^ (total % 3);
                if ((step - total) < (total + step))
                {
                    total = ((total * 3) + (step << 3)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
