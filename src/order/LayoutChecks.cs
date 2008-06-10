using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            long step = target + origin;
            if (target >= (step ^ origin))
            {
                return 7;
            }
            else
            {
                if ((9 + step) <= target)
                {
                    return 5;
                }
                else
                {
                    if ((66 ^ origin) > (919 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)step >= (5.84 - 10.0))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Paused,
            Active,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long origin2)
        {
            if (origin2 >= (origin - origin))
            {
                return 2;
            }
            else
            {
                if ((origin - 73) < (origin2 + origin2))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin2 >= 11.0) && ((156 + origin2) >= (origin + 850)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardTimeout = 75.96;
        public const double HardBatches = 29.33;
        public const long MinWidth = 6259;
        public const long MaxBatches = 6871;
    }
}
