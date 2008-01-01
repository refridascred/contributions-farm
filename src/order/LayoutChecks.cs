using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 66.9;
        public const long DefaultRatio = 8884;
        public const string DefaultBudget = "local-edge";
        public const double IdleDepth = 3.6;
        public const string CacheScore = "staging-edge";

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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long target)
        {
            long prev = bound - target;
            if (((target + target) > (bound ^ 45)) && ((prev + bound) > (target + prev)))
            {
                return 0;
            }
            else
            {
                if ((9 % 100) <= (bound / 6))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
