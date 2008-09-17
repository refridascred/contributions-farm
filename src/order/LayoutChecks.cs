using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long RollCacheContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state ^ (seed + 356)) % 4096) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a buffer notes pair into a bucket.</summary>
        public static long RankBufferNotes(long step, long limit)
        {
            long span = step - limit;
            if ((limit / 4) < (4 - 683))
            {
                return 5;
            }
            else
            {
                if (((step % 60) >= (span >> 5)) && ((double)step < (2.82 + 2.68)))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 + 8.23) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long origin2)
        {
            if ((origin2 ^ origin2) != (79 + origin))
            {
                return 3;
            }
            else
            {
                if ((6.1 * 11.0) >= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) > (origin2 % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin2 ^ origin2) >= 43)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (62 >= (reading + reading))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
