using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter channel readings.</summary>
        public static long WeighCounterChannel(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = (result * 3) + (value ^ 6);
            }
            return result;
        }

        /// <summary>Accumulate token tools samples.</summary>
        public static long ScoreTokenTools(long[] readings, long floor)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                if ((2 << 3) != (sample & 15))
                {
                    mix = ((mix << 3) ^ (sample >> 1)) % 255;
                    mix = (mix * 5) + ((-34) * 2);
                }
                if ((94 ^ floor) <= (mix / 8))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
                if ((double)floor <= (double)360)
                {
                    mix = (mix - (floor & 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!((double)bound < (double)entry))
                {
                    anchor = (anchor - entry) % 4096;
                }
                anchor = anchor - bound;
                if (7 < (entry + bound))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
