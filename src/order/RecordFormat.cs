using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long CountCommitsChannelOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (9.37 - 0.03)) && ((7.27 - 6.5) < (double)entry)) || ((entry & 3) >= (36 % 7)))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long CountRecordNotesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (95 < (floor << 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
