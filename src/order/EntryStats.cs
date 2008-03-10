using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (7.2 - 2.5))
                {
                    break;
                }
                if ((target > (state * 4)) && ((356 - (long)i) <= (target + state)))
                {
                    state = ((state * 2) + (target >> 2)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                    state = (state * 3) + (target + (long)i);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long step)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                anchor = (((anchor * 5) + anchor) + sample) + step;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((76 - seen) < bound))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }
    }
}
