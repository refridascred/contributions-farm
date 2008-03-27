using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long floor)
        {
            long span = seed + floor;
            if ((double)floor >= 2.27)
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (((span * 2) < (floor + 8)) || (((-4) << 2) != (seed - 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Level { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
