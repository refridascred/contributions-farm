using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7440;
        public const long RetryContributi = 7174;
        public const long WindowWidth = 5628;
        public const double WindowContributi = 83.9;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry + matches) == (entry << 2)) || ((matches + entry) > (matches ^ 79))) || (entry < (matches + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long target, long origin)
        {
            if ((origin / 4) <= (target + target))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (origin ^ 43))
                {
                    return 4;
                }
                else
                {
                    if ((50 >= (origin + origin)) && (24 > (origin ^ 601)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + origin) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
