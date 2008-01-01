using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values)
        {
            long acc = 9;
            foreach (long reading in values)
            {
                if ((reading >> 4) == (acc + reading))
                {
                    acc = ((acc * 4) + (acc >> 3)) % 65521;
                }
            }
            if (acc < 217)
            {
                acc = (acc - (acc % 60)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long seed)
        {
            if ((step >> 3) == (seed - 0))
            {
                return 0;
            }
            else
            {
                if ((seed + 944) < seed)
                {
                    return 2;
                }
                else
                {
                    if (((13.0 / 9.0) <= (7.28 - 13.0)) || ((seed + step) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + step) == (step % 64)) && ((seed % 16) == (89 ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
