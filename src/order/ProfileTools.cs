using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((origin ^ 36) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin2 + origin2) != (origin2 % 16))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin2) >= origin2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin2 - origin2) <= (2 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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
